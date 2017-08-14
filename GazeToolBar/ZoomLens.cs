using EyeXFramework;
using EyeXFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ImageProcessing;
using WindowsAPI;

namespace GazeToolBar
{
    public partial class ZoomLens : Form
    {
        // TODO: Move this to settings json
        // Setting the width & height of the ZoomLens
        public static int ZOOMLENS_SIZE = 500;
        static List<Bitmap> listZoom = new List<Bitmap>();

        Graphics graphics;
        Graphics offScreenGraphics;
        Graphics mainCanvas;
        Bitmap zoomedScreenshot;
        Bitmap offScreenBitmap;
        FixationDetection fixdet;
        DrawingForm drawingForm;

        public Point Offset { get; set; }

        public ZoomLens(FixationDetection FixDet, FormsEyeXHost EyeXHost)
        {
            InitializeComponent();

            this.Width = ZOOMLENS_SIZE;
            this.Height = ZOOMLENS_SIZE;
            offScreenBitmap = new Bitmap(this.Width, this.Height);
            zoomedScreenshot = new Bitmap(this.Width, this.Height);
            mainCanvas = this.CreateGraphics();
            offScreenGraphics = Graphics.FromImage(offScreenBitmap);
            graphics = Graphics.FromImage(zoomedScreenshot);
            this.FormBorderStyle = FormBorderStyle.None;//removes window borders from form
            fixdet = FixDet;
            drawingForm = new DrawingForm(FixDet);
            //====================================================
            // This is for making form appear on top of window's menu
            TopMost = true;

            //gazeHighlight = new GazeHighlight(FixDet, offScreenGraphics, EHighlightShaderType.RedToGreen, this);
        }


        public void Start()
        {
            // Show the form that the user feedback image is drawn on
            drawingForm.Show();
            DrawTimer.Start();
        }


        public void ResetZoomLens()
        {
            // Stop timer, and hide drawing form and zoom form
            DrawTimer.Stop();
            drawingForm.ClearForm();
            Hide();          
        }


        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            // Show drawing form and tell him to draw
            drawingForm.Show();
            drawingForm.Draw(Offset);
        }
    }
}