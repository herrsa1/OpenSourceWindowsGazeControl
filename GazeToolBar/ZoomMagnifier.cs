using System;
using System.Windows.Forms;
using Karna.Magnification;
using System.Drawing;

namespace GazeToolBar
{
    public class ZoomMagnifier
    {
        private const int UPDATE_SPEED = 1; //how fast the lens will update

        //TODO: Move these to settings json
        public static bool DO_ZOOM = false;         //Zoom enabled
        public static float ZOOM_SPEED = 0.005F;    //Amount zoom will increment
        public static float ZOOM_MAX = 2F;          //Max zoom amount

        public Point FixationPoint { get; set; }
        private Form form;
        private Timer updateTimer;
        private RECT magWindowRect = new RECT();
        private IntPtr hwndMag;

        private bool hasInitialized;
        private float magnification;

        public ZoomMagnifier(Form displayForm)
        {
            Magnification = DO_ZOOM ? 1 : ZOOM_MAX; //Set magnification to the max if not zooming
            form = displayForm;
            form.TopMost = true;
            updateTimer = new Timer();

            InitLens();

            //Event handlers
            form.Resize += new EventHandler(form_Resize);
            form.FormClosing += new FormClosingEventHandler(form_FormClosing);
            updateTimer.Tick += new EventHandler(timer_Tick);

            updateTimer.Interval = UPDATE_SPEED;
            updateTimer.Enabled = true;
        }

        public void InitLens()
        {
            hasInitialized = NativeMethods.MagInitialize();
            if (hasInitialized)
            {
                IntPtr hInst = NativeMethods.GetModuleHandle(null);

                // Create a magnifier control that fills the client area.
                NativeMethods.GetClientRect(form.Handle, ref magWindowRect);
                hwndMag = NativeMethods.CreateWindow((int)ExtendedWindowStyles.WS_EX_CLIENTEDGE, NativeMethods.WC_MAGNIFIER, "Zoom Lens",
                    (int)WindowStyles.WS_CHILD | (int)WindowStyles.WS_VISIBLE,
                    magWindowRect.left, magWindowRect.top, magWindowRect.right, magWindowRect.bottom, form.Handle, IntPtr.Zero, hInst, IntPtr.Zero);

                // Set the magnification factor.
                Transformation matrix = new Transformation(Magnification);
                NativeMethods.MagSetWindowTransform(hwndMag, ref matrix);
            }
        }

        public virtual void UpdateMagnifier()
        {
            //If the magnifier is not setup correctly (will crash otherwise)
            if ((!hasInitialized) || (hwndMag == IntPtr.Zero))
            {
                return;
            }

            RECT sourceRect = new RECT();
            Point zoomPosition = GetZoomPosition();
            Rectangle screenBounds = Screen.FromControl(form).Bounds;

            //Magnified width and height
            int width = (int)(form.Width / Magnification);
            int height = (int)(form.Height / Magnification);

            //Form position
            form.Left = zoomPosition.X - (form.Width / 2);
            form.Top = zoomPosition.Y - (form.Height / 2);
            form.Left = Clamp(form.Left, 0, screenBounds.Width - form.Width);
            form.Top = Clamp(form.Top, 0, screenBounds.Height - form.Height);

            //Zoom rectangle position
            sourceRect.left = zoomPosition.X - (width / 2);
            sourceRect.top = zoomPosition.Y - (height / 2);
            sourceRect.left = Clamp(sourceRect.left, 0, screenBounds.Width - width);
            sourceRect.top = Clamp(sourceRect.top, 0, screenBounds.Height - height);

            NativeMethods.MagSetWindowSource(hwndMag, sourceRect);  //Sets the source of the zoom
            NativeMethods.InvalidateRect(hwndMag, IntPtr.Zero, true); // Force redraw.
        }

        public void Zoom()
        {
            if (DO_ZOOM)
            {
                Magnification += ZOOM_SPEED;
            }
        }

        //Gets the position that the zoom will be centered on
        public Point GetZoomPosition()
        {
            return FixationPoint;
        }

        //TODO: move to utility class
        //Forces an int to be between two integers
        public int Clamp(int current, int min, int max)
        {
            return (current < min) ? min : (current > max) ? max : current;
        }

        public void ResetZoomValue()
        {
            Magnification = 2.0f;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Zoom();
            UpdateMagnifier();
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateTimer.Enabled = false;
        }

        private void form_Resize(object sender, EventArgs e)
        {
            if (hasInitialized && (hwndMag != IntPtr.Zero))
            {
                NativeMethods.GetClientRect(form.Handle, ref magWindowRect);
                // Resize the control to fill the window.
                NativeMethods.SetWindowPos(hwndMag, IntPtr.Zero, magWindowRect.left, magWindowRect.top, magWindowRect.right, magWindowRect.bottom, 0);
            }
        }

        //the magnification factor
        private float Magnification
        {
            set
            {
                if (magnification != value)
                {
                    magnification = value;
                    if (magnification > ZOOM_MAX)
                    {
                        magnification = ZOOM_MAX;
                    }
                    // Set the magnification factor.
                    Transformation matrix = new Transformation(magnification);
                    NativeMethods.MagSetWindowTransform(hwndMag, ref matrix);
                }
            }
            get { return magnification; }
        }
    }
}

