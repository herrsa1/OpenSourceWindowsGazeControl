using EyeXFramework.Forms;
using System;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;



namespace GazeToolBar
{
    static class Program
    {
        public static string path { get; set; }
        public static SettingJSON readSettings { get; set; }
        public static bool onStartUp { get; set; }
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //eyeXHost.Start();
            path = Application.StartupPath + "\\" + "Settings.json";
            ReadWriteJson();
            ReadWriteJson();
            onStartUp = AutoStart.IsOn();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static void ReadWriteJson()
        {
            if (!File.Exists(path))
            {
                SettingJSON defaultSetting = new SettingJSON();
                defaultSetting.fixationTimeLength = ValueNeverChange.DEFAULT_TIME_LENGTH;
                defaultSetting.fixationTimeOut = ValueNeverChange.DEFAULT_TIME_OUT;
                defaultSetting.leftClick = ValueNeverChange.KEY_FUNCTION_UNASSIGNED_MESSAGE;
                defaultSetting.doubleClick = ValueNeverChange.KEY_FUNCTION_UNASSIGNED_MESSAGE;
                defaultSetting.rightClick = ValueNeverChange.KEY_FUNCTION_UNASSIGNED_MESSAGE;
                defaultSetting.scoll = ValueNeverChange.KEY_FUNCTION_UNASSIGNED_MESSAGE;
                string JSONstr = JsonConvert.SerializeObject(defaultSetting);
                File.AppendAllText(path, JSONstr);
            }
            else
            {
                string s = File.ReadAllText(path);
                readSettings = JsonConvert.DeserializeObject<SettingJSON>(s);
            }
        }
    }
}
