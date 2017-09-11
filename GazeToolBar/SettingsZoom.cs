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
    public partial class SettingsZoom : SettingsBase
    {
        public SettingsZoom()
        {
            InitializeComponent();
        }

        private void SettingsZoom_Load(object sender, EventArgs e)
        {
            int PointMidX = Width / 2;
            int PointMidY = Height / 2;

            pnlZoomAmount.Location = new Point(PointMidX - (pnlZoomAmount.Width / 2), PointMidY - 100);
            pnlZoomSize.Location = new Point(PointMidX - (pnlZoomSize.Width / 2), PointMidY + 100);

        }
    }
}
