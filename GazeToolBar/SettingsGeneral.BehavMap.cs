using EyeXFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeToolBar
{
    partial class SettingsGeneral
    {
        int buttonClickDelay = 500;
        String notAssigned = "N/A";

        private void connectBehaveMap()
        {
            eyeXHost.Connect(bhavSettingMap);

            //Temp for 100 
            //Will change later
            bhavSettingMap.Add(btnAutoStart, new GazeAwareBehavior(OnbtnAutoStart_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnFixTimeLengthMins, new GazeAwareBehavior(OnbtnFixTimeLengthMins_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnFixTimeLengthPlus, new GazeAwareBehavior(OnbtnFixTimeLengthPlus_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnFixTimeOutMins, new GazeAwareBehavior(OnbtnFixTimeOutMins_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnFixTimeOutPlus, new GazeAwareBehavior(OnbtnFixTimeOutPlus_Click) { DelayMilliseconds = buttonClickDelay });

            //highlight panels
            bhavSettingMap.Add(pnlFTLMins, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFTLPlus, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFTOMins, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFTOPlus, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlAuto, new GazeAwareBehavior(OnGazeChangeBTColour));
        }

        //toggle border on and off on gaze to gaze to give feed back.
        private void OnGazeChangeBTColour(object s, GazeAwareEventArgs e)
        {
            var sentButton = s as Panel;
            if (sentButton != null)
            {
                sentButton.BackColor = (e.HasGaze) ? Color.Red : Color.Black;
            }
        }
        private void OnbtnFixTimeOutPlus_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnFixTimeOutPlus.PerformClick();
        }

        private void OnbtnFixTimeOutMins_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnFixTimeOutMins.PerformClick();
        }

        private void OnbtnFixTimeLengthPlus_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnFixTimeLengthPlus.PerformClick();
        }

        private void OnbtnFixTimeLengthMins_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnFixTimeLengthMins.PerformClick();
        }

        private void OnbtnAutoStart_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnAutoStart.PerformClick();
        }
    }
}
