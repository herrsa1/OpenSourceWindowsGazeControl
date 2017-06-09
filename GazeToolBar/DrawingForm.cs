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
    public partial class DrawingForm : Form
    {
        Graphics graphics;
        Size highlightSize;
        ZoomLens lensForm;
        Point currentGaze;
        Image crosshairImage;

        public DrawingForm(FixationDetection fixDet, ZoomLens lensForm)
        {
            InitializeComponent();

            highlightSize = new Size(40, 40);
            this.lensForm = lensForm;
            currentGaze = new Point();

            fixDet.currentProgress += updateLocation;
            crosshairImage = Properties.Resources.crosshair_1;
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {
            Top = 0;
            Left = 0;
            FormBorderStyle = FormBorderStyle.None;
            TransparencyKey = Color.Thistle;
            BackColor = Color.Thistle;
            Width = ValueNeverChange.SCREEN_SIZE.Width;
            Height = ValueNeverChange.SCREEN_SIZE.Height;
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

        private void updateLocation(object o, FixationProgressEventArgs progress)
        {
            currentGaze.X = progress.X;
            currentGaze.Y = progress.Y;
        }
    }
}
