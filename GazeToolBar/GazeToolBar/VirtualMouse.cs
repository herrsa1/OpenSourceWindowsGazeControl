﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput.Native;


namespace GazeToolBar
{
    public static class VirtualMouse
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
       
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        public const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {

            //click now working, but moves cursor on screen.
            SetCursorPos(xpos, ypos);

            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            Thread.Sleep(200);
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);

            Console.WriteLine("LeftMouseClick X" + xpos + " Y" + ypos);
           
        }

        public static void LeftDoubleClick(int xpos, int ypos)
        {
            WindowsInput.InputSimulator testSim = new WindowsInput.InputSimulator();
            SetCursorPos(xpos, ypos);
            testSim.Mouse.LeftButtonDoubleClick();
        }

        public static void RightMouseClick(int xpos, int ypos)
        {

            WindowsInput.InputSimulator testSim = new WindowsInput.InputSimulator();
            SetCursorPos(xpos, ypos);
            testSim.Mouse.RightButtonClick();

        }
    }
}
