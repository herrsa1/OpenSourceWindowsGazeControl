using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShellLib;
using System.Drawing;
using Newtonsoft.Json;
using System.IO;
using EyeXFramework.Forms;
using System.Linq;

namespace GazeToolBar
{
    public partial class HomeControlPage : Form
    {
        private Form1 form1;

        private Size confirmSize = new Size(595, 300);
        private static FormsEyeXHost eyeXHost;
        private String[] homeLables = new String[] { };
        private HomeControlPage.ButtonType[] homeButtonTypes = new HomeControlPage.ButtonType[] { };
        private List<Button> buttons = new List<Button>();
        private List<Boolean> buttonsPower = new List<Boolean>();

        public enum ButtonType { light, heater, tv, undefined }       

        public HomeControlPage(Form1 form1, FormsEyeXHost EyeXHost)
        {
            eyeXHost = EyeXHost;
            InitializeComponent();
            this.form1 = form1;
            //This code makes form full screen
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //End                
        }

        private void controlRelocateAndResize()
        {
            ReletiveSize.panelSaveAndCancel(pnlHomeCancel.Width, pnlHomeCancel.Height);
        }

        public void ChangeButtonColor(Button button, bool onOff, bool hasText)
        {
            button.BackColor = onOff ? Constants.SelectedColor : Constants.SettingButtonColor;
            if (hasText)
            {
                if (onOff)
                {
                    button.ForeColor = Color.Black;
                }
                else
                {
                    button.ForeColor = Color.White;
                }
            }
        }
        private void ini_Buttons()
        {
            buttons.Add(btn1);
            buttons.Add(btn2);
            buttons.Add(btn3);
            //========TO BE REPLACED=========
            //boolean variables to be replaced with devices ability to send current power status
            buttonsPower.Add(false);
            buttonsPower.Add(false);
            buttonsPower.Add(false);
            //=======================
            for (int i = 0; i <= buttons.Count-1; i++)
            {
                buttons[i].TextAlign = ContentAlignment.BottomCenter;
                buttons[i].Font = new Font("Arial",12);
                buttons[i].Text = homeLables[i];
                updateBtnImage();
            }
        }

        private void updateBtnImages(int i)
        {
            switch (homeButtonTypes[i])
            {
                case ButtonType.heater:
                    buttons[i].Image = Properties.Resources.heater;
                    break;
                case ButtonType.light:
                    buttons[i].Image = Properties.Resources.Light;
                    break;
                case ButtonType.tv:
                    buttons[i].Image = Properties.Resources.tv;
                    break;
                default:
                    buttons[i].Image = null;
                    break;
            }
        }

        private void btnHomeCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void updateBtnImage()
        {
            for (int i = 0; i <= buttons.Count - 1; i++)
            {
                switch (homeButtonTypes[i])
                {
                    case HomeControlPage.ButtonType.heater:
                        if (buttonsPower[i])
                        { buttons[i].Image = Properties.Resources.heaterOn; }
                        else
                        { buttons[i].Image = Properties.Resources.heater; }
                        break;
                    case HomeControlPage.ButtonType.light:
                        if (buttonsPower[i])
                        { buttons[i].Image = Properties.Resources.LightOn; }
                        else
                        { buttons[i].Image = Properties.Resources.Light; }
                        break;
                    case HomeControlPage.ButtonType.tv:
                        if (buttonsPower[i])
                        { buttons[i].Image = Properties.Resources.tvOn; }
                        else
                        { buttons[i].Image = Properties.Resources.tv; }
                        break;
                    default:
                        buttons[i].Image = null;
                        break;
                }
            }
        }
        //========TODO==========
        //replace buttonsPower[i] = !buttonsPower[i] to python method to toggle power
        private void btn1_Click(object sender, EventArgs e)
        {
            buttonsPower[0] = !buttonsPower[0];
            updateBtnImage();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            buttonsPower[1] = !buttonsPower[1];
            updateBtnImage();
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            buttonsPower[2] = !buttonsPower[2];
            updateBtnImage();           
        }       

        private void HomePage_Shown(object sender, EventArgs e)
        {
            connectBehaveMap();
            form1.shortCutKeyWorker.StopKeyboardWorker();
        }

        private void HomeControlPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.shortCutKeyWorker.StartKeyBoardWorker();
        }

        private void HomeControlPage_Shown(object sender, EventArgs e)
        {
            connectBehaveMap();
            form1.shortCutKeyWorker.StopKeyboardWorker();
        }

        private void HomeControlPage_Load(object sender, EventArgs e)
        {
            Program.ReadWriteJson();

            homeLables = Program.readSettings.homeLables;
            homeButtonTypes = Program.readSettings.homeButtonTypes;

            ini_Buttons();
        }
    }
}
