using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeXFramework.Forms;

namespace GazeToolBar
{
    public partial class SettingsGeneral : SettingsBase
    {
        public SettingsGeneral()
        {
            InitializeComponent();
        }

        private void SettingsGeneral_Load(object sender, EventArgs e)
        {

            int PointMidX = Width / 2;
            int PointMidY = Height / 2;

            panelPrecision.Location = new Point(PointMidX - (panelPrecision.Width / 2), PointMidY - 100);
            pnlFixationTimeOut.Location = new Point(PointMidX - (pnlFixationTimeOut.Width / 2), PointMidY + 100);

            pnlOtherAuto.Location = new Point(PointMidX - (pnlOtherAuto.Width / 2), Height - pnlOtherAuto.Height - 150);

            trackBarFixTimeLength.Value = (Settings.fixationTimeLength - Constants.MIN_TIME_LENGTH) / Constants.GAP_TIME_LENGTH;
            trackBarFixTimeOut.Value = (Settings.fixationTimeOut - Constants.MIN_TIME_OUT) / Constants.GAP_TIME_OUT;
        }

        private void btnAutoStart_Click(object sender, EventArgs e)
        {
            if (Program.onStartUp)
            {
                AutoStart.SetOff();
                Program.onStartUp = !Program.onStartUp;
                btnAutoStart.ForeColor = Color.White;
            }
            else
            {
                if (AutoStart.SetOn())
                {
                    Program.onStartUp = !Program.onStartUp;
                    btnAutoStart.ForeColor = Color.Black;
                }
            }

            Sidebar.OnStartTextChange();
        }

        private void btnFixTimeLengthMins_Click(object sender, EventArgs e)
        {
            changeTrackBarValue(trackBarFixTimeLength, "D");
        }

        private void btnFixTimeLengthPlus_Click(object sender, EventArgs e)
        {
            changeTrackBarValue(trackBarFixTimeLength, "I");
        }

        private void btnFixTimeOutMins_Click(object sender, EventArgs e)
        {
            changeTrackBarValue(trackBarFixTimeOut, "D");
        }

        private void btnFixTimeOutPlus_Click(object sender, EventArgs e)
        {
            changeTrackBarValue(trackBarFixTimeOut, "I");
        }

        private void trackBarFixTimeLength_ValueChanged(object sender, EventArgs e)
        {
            Sidebar.stateManager.fixationWorker.FixationDetectionTimeLength = trackBarFixTimeLength.Value * Constants.GAP_TIME_LENGTH + Constants.MIN_TIME_LENGTH;
            Sidebar.stateManager.fixationWorker.fixationTimer.Interval = trackBarFixTimeLength.Value * Constants.GAP_TIME_LENGTH + Constants.MIN_TIME_LENGTH;
            Settings.fixationTimeLength = trackBarFixTimeLength.Value * Constants.GAP_TIME_LENGTH + Constants.MIN_TIME_LENGTH;

        }

        private void trackBarFixTimeOut_ValueChanged(object sender, EventArgs e)
        {
            Sidebar.stateManager.fixationWorker.FixationTimeOutLength = trackBarFixTimeOut.Value * Constants.GAP_TIME_OUT + Constants.MIN_TIME_OUT;
            Sidebar.stateManager.fixationWorker.timeOutTimer.Interval = trackBarFixTimeOut.Value * Constants.GAP_TIME_OUT + Constants.MIN_TIME_OUT;
            Settings.fixationTimeOut = trackBarFixTimeOut.Value * Constants.GAP_TIME_OUT + Constants.MIN_TIME_OUT;
        }
    }
}
