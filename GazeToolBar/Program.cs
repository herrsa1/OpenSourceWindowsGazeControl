﻿using EyeXFramework.Forms;
using System;
using System.Windows.Forms;

using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;


namespace GazeToolBar
{
    static class Program
    {
        //private static FormsEyeXHost eyeXHost = new FormsEyeXHost();

        
        //public static FormsEyeXHost EyeXHost
        //{
        //    get { return eyeXHost; }
        //}
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //eyeXHost.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(); 
           // eyeXHost.Dispose();

            //The statemanager will instatiate all needed objects
            StateManager stateManager = new StateManager();
            
        }
    }
}
