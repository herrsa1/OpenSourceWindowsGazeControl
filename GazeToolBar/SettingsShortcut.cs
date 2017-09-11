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
    public partial class SettingsShortcut : SettingsBase
    {
        private Boolean WaitForUserKeyPress;
        ActionToBePerformed actionToAssignKey;

        public SettingsShortcut()
        {
            InitializeComponent();
        }

        private void SettingsShortcut_Load(object sender, EventArgs e)
        {
            int PointMidX = Width / 2;
            int PointMidY = Height / 2;

            panel1.Location = new Point(PointMidX - (panel1.Width / 2), PointMidY - (panel1.Height / 2));

            Sidebar.LowLevelKeyBoardHook.OnKeyPressed += GetKeyPress;

            lbDouble.Text = Sidebar.FKeyMapDictionary[ActionToBePerformed.DoubleClick];
            lbRight.Text = Sidebar.FKeyMapDictionary[ActionToBePerformed.RightClick];
            lbLeft.Text = Sidebar.FKeyMapDictionary[ActionToBePerformed.LeftClick];
            lbScroll.Text = Sidebar.FKeyMapDictionary[ActionToBePerformed.Scroll];
        }

        void updateLabel(String newKey, ActionToBePerformed functiontoAssign)
        {
            switch (functiontoAssign)
            {
                case ActionToBePerformed.LeftClick:
                    lbLeft.Text = newKey;
                    break;
                case ActionToBePerformed.RightClick:
                    lbRight.Text = newKey;
                    break;
                case ActionToBePerformed.Scroll:
                    lbScroll.Text = newKey;
                    break;
                case ActionToBePerformed.DoubleClick:
                    lbDouble.Text = newKey;
                    break;
            }
        }

        public void GetKeyPress(object o, HookedKeyboardEventArgs pressedKey)
        {
            String keyPressed = pressedKey.KeyPressed.ToString();

            if (WaitForUserKeyPress)
            {

                if (checkIfKeyIsAssignedAlready(keyPressed, Sidebar.shortCutKeyWorker.keyAssignments))
                {
                    lbFKeyFeedback.Text = keyPressed + " already assigned.";
                }
                else
                {
                    Sidebar.shortCutKeyWorker.keyAssignments[actionToAssignKey] = keyPressed;
                    updateLabel(pressedKey.KeyPressed.ToString(), actionToAssignKey);
                    Settings.leftClick = lbLeft.Text;
                    Settings.doubleClick = lbDouble.Text;
                    Settings.rightClick = lbRight.Text;
                    Settings.scoll = lbScroll.Text;
                    WaitForUserKeyPress = false;
                    lbFKeyFeedback.Text = "";
                }
            }
        }

        private bool checkIfKeyIsAssignedAlready(String ValueToCheck, Dictionary<ActionToBePerformed, String> KeyAssignedDict)
        {

            foreach (KeyValuePair<ActionToBePerformed, String> currentKVP in KeyAssignedDict)
            {
                if (currentKVP.Value == ValueToCheck)
                {
                    return true;
                }
            }

            return false;
        }

        private void SettingsShortcut_FormClosed(object sender, FormClosedEventArgs e)
        {
            WaitForUserKeyPress = false;
        }

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

        String notAssigned = "N/A";

        private void btClearFKeyLeftClick_Click(object sender, EventArgs e)
        {
            Sidebar.shortCutKeyWorker.keyAssignments[ActionToBePerformed.LeftClick] = notAssigned;
            lbLeft.Text = notAssigned;
        }

        private void btClearFKeyRightClick_Click(object sender, EventArgs e)
        {
            Sidebar.shortCutKeyWorker.keyAssignments[ActionToBePerformed.RightClick] = notAssigned;
            lbRight.Text = notAssigned;
        }

        private void btClearFKeyDoubleClick_Click(object sender, EventArgs e)
        {
            Sidebar.shortCutKeyWorker.keyAssignments[ActionToBePerformed.LeftClick] = notAssigned;
            lbDouble.Text = notAssigned;
        }

        private void btClearFKeyScroll_Click(object sender, EventArgs e)
        {
            Sidebar.shortCutKeyWorker.keyAssignments[ActionToBePerformed.Scroll] = notAssigned;
            lbScroll.Text = notAssigned;
        }

    }
}
