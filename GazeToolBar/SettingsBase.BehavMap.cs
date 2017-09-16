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
    partial class SettingsBase
    {
        int buttonClickDelay = 500;
        String notAssigned = "N/A";

        private void connectBehaveMap()
        {
            eyeXHost.Connect(bhavSettingMap);

            //Temp for 100 
            //Will change later
            bhavSettingMap.Add(btnSave, new GazeAwareBehavior(OnbtnSave_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnCancel, new GazeAwareBehavior(OnbtnCancel_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnGeneralSetting, new GazeAwareBehavior(OnBtnGeneralSettingClick) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnShortCutKeySetting, new GazeAwareBehavior(OnBtnKeyboardSettingClick) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnZoomSettings, new GazeAwareBehavior(OnBtnGeneralSettingClick) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnRearrangeSetting, new GazeAwareBehavior(OnBtnGeneralSettingClick) { DelayMilliseconds = buttonClickDelay });

            //highlight panels

            bhavSettingMap.Add(pnlGeneralButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlKeysButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlSave, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlCancel, new GazeAwareBehavior(OnGazeChangeBTColour));
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

        private void OnbtnCancel_Click(object sender, GazeAwareEventArgs e)
        {
            btnCancel.PerformClick();
        }

        private void OnbtnSave_Click(object sender, GazeAwareEventArgs e)
        {
            btnSave.PerformClick();
        }

        private void OnBtnGeneralSettingClick(object sender, GazeAwareEventArgs e)
        {
            btnGeneralSetting.PerformClick();
        }

        private void OnBtnKeyboardSettingClick(object sender, GazeAwareEventArgs e)
        {
            btnShortCutKeySetting.PerformClick();
        }
    }
}
