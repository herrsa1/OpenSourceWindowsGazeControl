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
    partial class Settings
    {

        int buttonClickDelay = 500;
        String notAssigned = "N/A";

        private void connectBehaveMap()
        {
            eyeXHost.Connect(bhavSettingMap);

            //Temp for 100 
            //Will change later
            bhavSettingMap.Add(btnAutoStart, new GazeAwareBehavior(OnbtnAutoStart_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnSave, new GazeAwareBehavior(OnbtnSave_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnCancel, new GazeAwareBehavior(OnbtnCancel_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnFixTimeLengthMins, new GazeAwareBehavior(OnbtnFixTimeLengthMins_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnFixTimeLengthPlus, new GazeAwareBehavior(OnbtnFixTimeLengthPlus_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnFixTimeOutMins, new GazeAwareBehavior(OnbtnFixTimeOutMins_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnFixTimeOutPlus, new GazeAwareBehavior(OnbtnFixTimeOutPlus_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnZoomSizeMinus, new GazeAwareBehavior(OnBtnZoomSizeMinus_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnZoomSizePlus, new GazeAwareBehavior(OnBtnZoomSizePlus_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnZoomAmountMinus, new GazeAwareBehavior(OnBtnZoomAmountMinus_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnZoomAmountPlus, new GazeAwareBehavior(OnBtnZoomAmountPlus_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnMoveUp, new GazeAwareBehavior(OnBtnMoveUp_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnMoveDown, new GazeAwareBehavior(OnBtnMoveDown_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnRemove, new GazeAwareBehavior(OnBtnRemove_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnActionDoubleLeftClick, new GazeAwareBehavior(OnBtnActionDoubleLeftClick_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnActionKeyboard, new GazeAwareBehavior(OnBtnActionKeyboard_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnActionLeftClick, new GazeAwareBehavior(OnBtnActionLeftClick_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnActionRightClick, new GazeAwareBehavior(OnBtnActionRightClick_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnActionScrollClick, new GazeAwareBehavior(OnBtnActionScrollClick_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnActionSettings, new GazeAwareBehavior(OnBtnActionSettings_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(buttonCrosshairDown, new GazeAwareBehavior(OnButtonCrosshairDown_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(buttonCrosshairUp, new GazeAwareBehavior(OnButtonCrosshairUp_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnGeneralSetting, new GazeAwareBehavior(OnBtnGeneralSetting_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnShortCutKeySetting, new GazeAwareBehavior(OnBtnKeyboardSetting_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnZoomSettings, new GazeAwareBehavior(OnBtnZoomSettings_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btnRearrangeSetting, new GazeAwareBehavior(OnBtnRearrangeSetting_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(buttonCrosshairSetting, new GazeAwareBehavior(OnbuttonCrosshairSetting_Click) { DelayMilliseconds = buttonClickDelay });

            //Set buttons
            bhavSettingMap.Add(btFKeyLeftClick, new GazeAwareBehavior(btFKeyLeftClick_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btFKeyRightClick, new GazeAwareBehavior(btFKeyRightClick_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btFKeyDoubleClick, new GazeAwareBehavior(btFKeyDoubleClick_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btFKeyScroll, new GazeAwareBehavior(btFKeyScroll_Click) { DelayMilliseconds = buttonClickDelay });
            //bhavSettingMap.Add(btFKeyDrapAndDrop, new GazeAwareBehavior(btFKeyDrapAndDrop_Click) { DelayMilliseconds = buttonClickDelay });
            //clear buttons
            bhavSettingMap.Add(btClearFKeyLeftClick, new GazeAwareBehavior(btClearFKeyLeftClick_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btClearFKeyRightClick, new GazeAwareBehavior(btClearFKeyRightClick_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btClearFKeyDoubleClick, new GazeAwareBehavior(btClearFKeyDoubleClick_Click) { DelayMilliseconds = buttonClickDelay });
            bhavSettingMap.Add(btClearFKeyScroll, new GazeAwareBehavior(btClearFKeyScroll_Click) { DelayMilliseconds = buttonClickDelay });
            // bhavSettingMap.Add(btClearFKeyDrapAndDrop, new GazeAwareBehavior(btClearFKeyDrapAndDrop_Click) { DelayMilliseconds = buttonClickDelay });
            //highlight panels
            bhavSettingMap.Add(pnlFKeyHighlight1, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFKeyHighlight2, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFKeyHighlight3, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFKeyHighlight4, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFKeyHighlight5, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFKeyHighlight6, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFKeyHighlight7, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFKeyHighlight8, new GazeAwareBehavior(OnGazeChangeBTColour));
            // bhavSettingMap.Add(pnlFKeyHighlight9, new GazeAwareBehavior(OnGazeChangeBTColour));
            // bhavSettingMap.Add(pnlFKeyHighlight10, new GazeAwareBehavior(OnGazeChangeBTColour));



            bhavSettingMap.Add(pnlGeneralButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlKeysButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlZoomButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlRearrangeButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(panelCrosshairButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFTLMins, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFTLPlus, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFTOMins, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlFTOPlus, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlAuto, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlSave, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlCancel, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlZWSMinus, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlZWSPlus, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlZIAMinus, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlZIAPlus, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlMoveUpButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlMoveDownButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlRemoveButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlDoubleLeftClickButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlKeyboardButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlLeftClickButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlRightClickButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlScrollClickButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlSettingsButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlCrosshairDownButton, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavSettingMap.Add(pnlCrosshairUpButton, new GazeAwareBehavior(OnGazeChangeBTColour));

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

        private void OnbtnCancel_Click(object sender, GazeAwareEventArgs e)
        {
            btnCancel.PerformClick();
        }

        private void OnbtnSave_Click(object sender, GazeAwareEventArgs e)
        {
            btnSave.PerformClick();
        }

        private void OnbtnAutoStart_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnAutoStart.PerformClick();
        }

        private void OnBtnGeneralSetting_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnGeneralSetting.PerformClick();
        }

        private void OnBtnKeyboardSetting_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnShortCutKeySetting.PerformClick();
        }

        private void OnBtnZoomSettings_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnZoomSettings.PerformClick();
        }

        private void OnBtnRearrangeSetting_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnRearrangeSetting.PerformClick();
        }

        private void OnBtnZoomSizeMinus_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnZoomSizeMinus.PerformClick();
        }

        private void OnBtnZoomSizePlus_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnZoomSizePlus.PerformClick();
        }

        private void OnBtnZoomAmountMinus_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnZoomAmountMinus.PerformClick();
            MessageBox.Show("Event called!!");
        }

        private void OnBtnZoomAmountPlus_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnZoomAmountPlus.PerformClick();
        }

        private void OnBtnMoveUp_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnMoveUp.PerformClick();
        }

        private void OnBtnMoveDown_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnMoveDown.PerformClick();
        }

        private void OnBtnRemove_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnRemove.PerformClick();
        }

        private void OnBtnActionDoubleLeftClick_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnActionDoubleLeftClick.PerformClick();
        }

        private void OnBtnActionKeyboard_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnActionKeyboard.PerformClick();
        }

        private void OnBtnActionLeftClick_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnActionLeftClick.PerformClick();
        }

        private void OnBtnActionRightClick_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnActionRightClick.PerformClick();
        }

        private void OnBtnActionScrollClick_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnActionScrollClick.PerformClick();
        }

        private void OnBtnActionSettings_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btnActionSettings.PerformClick();
        }

        private void OnbuttonCrosshairSetting_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) buttonCrosshairSetting.PerformClick();
        }

        private void OnButtonCrosshairDown_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) buttonCrosshairDown.PerformClick();
        }

        private void OnButtonCrosshairUp_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) buttonCrosshairUp.PerformClick();
        }



        //====================================================================================


        //Shortcut keys panel buy button event methods. 


        //====================================================================================

        ActionToBePerformed actionToAssignKey;

        private void btFKeyLeftClick_Click(object sender, EventArgs e)
        {
            WaitForUserKeyPress = true;
            actionToAssignKey = ActionToBePerformed.LeftClick;
            lbFKeyFeedback.Text = "please press a key";

        }

        private void btFKeyRightClick_Click(object sender, EventArgs e)
        {
            WaitForUserKeyPress = true;
            actionToAssignKey = ActionToBePerformed.RightClick;
            lbFKeyFeedback.Text = "please press a key";
        }

        private void btFKeyDoubleClick_Click(object sender, EventArgs e)
        {
            WaitForUserKeyPress = true;
            actionToAssignKey = ActionToBePerformed.DoubleClick;
            lbFKeyFeedback.Text = "please press a key";
        }

        private void btFKeyScroll_Click(object sender, EventArgs e)
        {
            WaitForUserKeyPress = true;
            actionToAssignKey = ActionToBePerformed.Scroll;
            lbFKeyFeedback.Text = "please press a key";
        }

        //private void btFKeyDrapAndDrop_Click(object sender, EventArgs e)
        //{

        //}


        //Clear key map

        private void btClearFKeyLeftClick_Click(object sender, EventArgs e)
        {
            form1.shortCutKeyWorker.keyAssignments[ActionToBePerformed.LeftClick] = notAssigned;
            lbLeft.Text = notAssigned;
        }

        private void btClearFKeyRightClick_Click(object sender, EventArgs e)
        {
            form1.shortCutKeyWorker.keyAssignments[ActionToBePerformed.RightClick] = notAssigned;
            lbRight.Text = notAssigned;
        }

        private void btClearFKeyDoubleClick_Click(object sender, EventArgs e)
        {
            form1.shortCutKeyWorker.keyAssignments[ActionToBePerformed.LeftClick] = notAssigned;
            lbDouble.Text = notAssigned;
        }

        private void btClearFKeyScroll_Click(object sender, EventArgs e)
        {
            form1.shortCutKeyWorker.keyAssignments[ActionToBePerformed.Scroll] = notAssigned;
            lbScroll.Text = notAssigned;
        }

        //private void btClearFKeyDrapAndDrop_Click(object sender, EventArgs e)
        //{

        //}


    }
}
