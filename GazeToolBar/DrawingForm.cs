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

        public DrawingForm(FixationDetection fixDet)
        {
            InitializeComponent();

            // If wanting to draw a fillEllipse, or re-introduce gazeHighlight
            // then un-comment the below line to set size
            // highlightSize = new Size(40, 40);
            currentGaze = new Point();

            // Subscride to the event which gives current co-ordinates
            // of current eye position on screen
            fixDet.currentProgress += updateLocation;
            // Load the user feedback image
            crosshairImage = Properties.Resources.crosshair_1;
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
            Width = ValueNeverChange.SCREEN_SIZE.Width;
            Height = ValueNeverChange.SCREEN_SIZE.Height;
            FormBorderStyle = FormBorderStyle.None;
            TransparencyKey = Color.Thistle;
            BackColor = Color.Thistle;
            graphics = CreateGraphics();
            TopMost = true;
        }


        public void Draw()
        {
            Point formCoordinates = currentGaze;

            Refresh();

            int crossHairX = formCoordinates.X - (crosshairImage.Width / 2);
            int crossHairY = formCoordinates.Y - (crosshairImage.Height / 2);

            graphics.DrawImage(crosshairImage, crossHairX, crossHairY);
        }

        public void ClearForm()
        {
            Refresh();
            Hide();
        }

        /// <summary>
        /// Updates point to draw feedback image via progress event args
        /// </summary>
        /// <param name="o"></param>
        /// <param name="progress"></param>
        private void updateLocation(object o, FixationProgressEventArgs progress)
        {
            currentGaze.X = progress.X;
            currentGaze.Y = progress.Y;
        }
    }
}
