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
            
            //TESING PYTHON IMPLEMENTATION===========================
            //TODO:
            //Reduce loading times
            //convert python objects to clr objects

            using (Py.GIL())
            {
                dynamic broadlink = Py.Import("broadlink");

                //(0 = none, 1 = WEP, 2 = WPA1, 3 = WPA2, 4 = WPA1/2)
                broadlink.setup("SPARK-4LDFTZ", "P7FKRAA7XS", 3);

                devices = broadlink.discover(Py.kw("timeout", 5));

                for (int i = 0; i <= devices.check_power(); i++)
                {
                    devices[i].auth();
                    devices[i].check_power();
                    devices[i].set_power(!devices[i].check_power());
                }
            }
            //TESING PYTHON IMPLEMENTATION===========================
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
        private void btn1_Click(object sender, EventArgs e)
        {
            buttonsPower[0] = !buttonsPower[0];
            updateBtnImage(0);
            //using (Py.GIL())
            //{
            //    dynamic np = Py.Import("numpy");
            //    Console.WriteLine(np.cos(np.pi * 2));

            //    dynamic sin = np.sin;
            //    Console.WriteLine(sin(5));

            //    double c = np.cos(5) + sin(5);
            //    Console.WriteLine(c);

            //    dynamic a = np.array(new List<float> { 1, 2, 3 });
            //    Console.WriteLine(a.dtype);

            //    dynamic b = np.array(new List<float> { 6, 5, 4 }, dtype: np.int32);
            //    Console.WriteLine(b.dtype);

            //    Console.WriteLine(a * b);
            //    Console.ReadKey();
            //}
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            buttonsPower[1] = !buttonsPower[1];
            updateBtnImage(1);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            buttonsPower[2] = !buttonsPower[2];
            updateBtnImage(2);           
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
