using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeToolBar
{
    /// <summary>
    /// This class is a full screen, transparent form.
    /// It's purpose is for drawing the user feedback when zoomed in.
    /// 
    /// </summary>
    public partial class DrawingForm : Form
    {
        Graphics graphics;
        //Size highlightSize;
        Point currentGaze;
        Image crosshairImage;
        private IFixationSmoother smoother;

        public DrawingForm()
        {
            InitializeComponent();

            smoother = CreateSmoother();
            // If wanting to draw a fillEllipse, or re-introduce gazeHighlight
            // then un-comment the below line to set size
            // highlightSize = new Size(40, 40);
            currentGaze = new Point();

            // Load the user feedback image
            crosshairImage = Properties.Resources.crosshair_2;
        }



        /// <summary>
        /// Make form full screen, remove border, and make transparent
        /// Also give a graphics instance and set to topmost (for yet to be finished win10 menu bug)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawingForm_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            Width = Constants.SCREEN_SIZE.Width;
            Height = Constants.SCREEN_SIZE.Height;
            FormBorderStyle = FormBorderStyle.None;
            TransparencyKey = Color.Thistle;
            BackColor = Color.Thistle;
            graphics = CreateGraphics();
            TopMost = true;
        }

        public IFixationSmoother CreateSmoother()
        {
            return new FixationSmootherExponential(10);
        }

        public void SetCrossHairPos(Point p)
        {
            GazePoint pp = smoother.UpdateAndGetSmoothPoint(p.X, p.Y);
            currentGaze = new Point((int)pp.X, (int)pp.Y);
        }

        public void SetCrossHairPos(int x, int y)
        {
            SetCrossHairPos(new Point(x, y));
        }

        public void Draw()
        {
            Point formCoordinates = currentGaze;

            Refresh();

            int crossHairX = (formCoordinates.X - (crosshairImage.Width / 2));
            int crossHairY = (formCoordinates.Y - (crosshairImage.Height / 2));

         //    crossHairX = Math.Max(0, crossHairX);
        //   crossHairY = Math.Max(0, crossHairY);

            graphics.DrawImage(crosshairImage, crossHairX, crossHairY);
        }

        public void ClearForm()
        {
            Refresh();
            Hide();
            smoother = CreateSmoother();
        }
    }
}
