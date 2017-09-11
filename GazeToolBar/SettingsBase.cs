using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GazeToolBar
{
    public partial class SettingsBase : Form
    {
        public Form1 Sidebar
        {
            get;
            set;
        }

        public SettingJSON Settings
        {
            get;
            set;
        }

        public SettingsBase()
        {
            InitializeComponent();

        }

        private void SettingsBase_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            int PointMidX = Width / 2;
            panelSaveAndCancel.Location = new Point(PointMidX - (panelSaveAndCancel.Width / 2), Height - (panelSaveAndCancel.Height + 50));

            pnlSwitchSetting.Location = new Point(PointMidX - (pnlSwitchSetting.Width / 2), 10);
        }

        private void btnGeneralSetting_Click(object sender, EventArgs e)
        {
            SettingsGeneral newForm = new SettingsGeneral();
            newForm.Sidebar = Sidebar;
            newForm.Settings = Settings;
            newForm.Show();

            Close();
        }

        private void btnRearrangeSetting_Click(object sender, EventArgs e)
        {
            SidebarArrangementForm newForm = new SidebarArrangementForm();
            newForm.Sidebar = Sidebar;
            newForm.Settings = Settings;
 
            newForm.Show();

            Close();
        }

        public static void Open(Form1 sidebar)
        {
            SettingsGeneral gen = new SettingsGeneral();
            gen.Sidebar = sidebar;
            gen.Settings = Program.readSettings;

            gen.Show();
        }

        private void btnZoomSettings_Click(object sender, EventArgs e)
        {
            SettingsZoom newForm = new SettingsZoom();
            newForm.Sidebar = Sidebar;
            newForm.Settings = Settings;
            newForm.Show();

            Close();
        }

        private void btnShortCutKeySetting_Click(object sender, EventArgs e)
        {
            SettingsShortcut newForm = new SettingsShortcut();
            newForm.Sidebar = Sidebar;
            newForm.Settings = Settings;

            newForm.Show();

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Sidebar.shortCutKeyWorker.StartKeyBoardWorker();

        }

        protected void changeTrackBarValue(TrackBar trackbar, String IncrementOrDecrement)
        {
            switch (IncrementOrDecrement)
            {
                case "I":
                    if (trackbar.Value != trackbar.Maximum) { trackbar.Value = ++trackbar.Value; }
                    break;
                case "D":
                    if (trackbar.Value != trackbar.Minimum) { trackbar.Value = --trackbar.Value; }
                    break;
            }
            trackbar.Update();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sidebarSettings = JsonConvert.SerializeObject(Program.readSettings);
            File.WriteAllText(Program.path, sidebarSettings);

            Sidebar.ArrangeSidebar(Program.readSettings.sidebar);

            string settings = JsonConvert.SerializeObject(Settings);
            File.WriteAllText(Program.path, settings);
            //MessageBox.Show("Save Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Sidebar.NotifyIcon.BalloonTipTitle = "Saving success";
            Sidebar.NotifyIcon.BalloonTipText = "Your settings are successfuly saved";
            this.Close();
            Sidebar.NotifyIcon.ShowBalloonTip(2000);
        }
    }
}
