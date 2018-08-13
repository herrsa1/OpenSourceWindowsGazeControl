using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ShellLib;
using System.Drawing;
using Newtonsoft.Json;
using System.IO;
using EyeXFramework.Forms;
using System.Linq;
using Python.Runtime;
using System.Collections;

namespace GazeToolBar
{
    public partial class HomeControlPage : Form
    {
        private Form1 form1;

        private Size confirmSize = new Size(595, 300);
        private static FormsEyeXHost eyeXHost;
        private String[] homeLables = new String[] { };
        private int?[] btnDeviceNumbers = new int?[] { };
        private HomeControlPage.ButtonType[] homeButtonTypes = new HomeControlPage.ButtonType[] { };
        private List<Button> buttons = new List<Button>();
        private List<Boolean> buttonsPower = new List<Boolean>();
        private dynamic devices;

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
            controlRelocateAndResize();

            //TESING PYTHON IMPLEMENTATION===========================
            //#TODO:
            //1)Reduce loading times(narrowed it down to broadlink.setup taking time to connect to wifi)
            //2)convert python objects to clr objects
            //
            //#Bugs:
            //1)cant count number of objects in device list due to being a python object so going past the number of devices crashes the program.
           
            using (Py.GIL())
            {
                dynamic broadlink = Py.Import("broadlink");
                dynamic json = Py.Import("json");

                //(0 = none, 1 = WEP, 2 = WPA1, 3 = WPA2, 4 = WPA1/2)
                //broadlink.setup("WiFi SSID", "PASSWORD", 3);
                broadlink.setup("SPARK-4LDFTZ", "P7FKRAA7XS", 3);

                devices = broadlink.discover(Py.kw("timeout", 5));

                //devices[i].auth() allows further communication with devices
                int nDevices = 1;
                for (int i = 0; i <= nDevices-1; i++)
                {
                    devices[i].auth();
                    devices[i].check_power();
                    MessageBox.Show(json.dumps(devices[i].check_power()));
                }
            }
            //TESING PYTHON IMPLEMENTATION===========================
        }

        private void controlRelocateAndResize()
        {
            ReletiveSize.panelSaveAndCancel(pnlHomeCancel.Width, pnlHomeCancel.Height);
        }

        private void ini_Buttons()
        {
            buttons.Add(btn1);
            buttons.Add(btn2);
            buttons.Add(btn3);
            //========TO BE REPLACED=========
            //boolean variables to be replaced with devices ability to send current power status
            //devices[i].check_power();
            buttonsPower.Add(false);
            buttonsPower.Add(false);
            buttonsPower.Add(false);
            //=======================
            for (int i = 0; i <= buttons.Count-1; i++)
            {
                buttons[i].TextAlign = ContentAlignment.BottomCenter;
                buttons[i].Font = new Font("Arial",12);
                buttons[i].Text = homeLables[i];
                updateBtnImages();
            }
        }

        private void updateBtnImage(int i)
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

        private void btnHomeCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void updateBtnImages()
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
        private void btnDefaultAction(int buttonNumber)
        {
            buttonsPower[buttonNumber] = !buttonsPower[buttonNumber];
            updateBtnImage(buttonNumber);
            using (Py.GIL())
            {
                devices[buttonNumber].set_power(!devices[buttonNumber].check_power());
            }
        }
        //btnDeviceNumbers is type int?(Nullable int). "btnDeviceNumbers[i] ?? default(int)" converts it to int
        private void btn1_Click(object sender, EventArgs e)
        {
            btnDefaultAction(btnDeviceNumbers[0] ?? default(int));
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            btnDefaultAction(btnDeviceNumbers[1] ?? default(int));
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            btnDefaultAction(btnDeviceNumbers[2] ?? default(int));
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
            btnDeviceNumbers = Program.readSettings.buttonDeviceNumbers;

            ini_Buttons();
        }
    }
}
