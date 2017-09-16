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
    }
}
