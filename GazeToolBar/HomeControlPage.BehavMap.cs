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
    partial class HomeControlPage
    {

        int buttonClickDelay = 500;

        private void connectBehaveMap()
        {
            eyeXHost.Connect(bhavHomeControlPageMap);
            
            setupMap();
            setupHomeControlMap();
        }

        private void setupMap()
        {
            bhavHomeControlPageMap.Add(btnHomeCancel, new GazeAwareBehavior(OnbtnHomeCancel_Click) { DelayMilliseconds = buttonClickDelay });
            bhavHomeControlPageMap.Add(pnlHomeCancel, new GazeAwareBehavior(OnGazeChangeBTColour));
        }

        private void setupHomeControlMap()
        {
            bhavHomeControlPageMap.Add(btn1, new GazeAwareBehavior(OnBtn1_Click) { DelayMilliseconds = buttonClickDelay });
            bhavHomeControlPageMap.Add(btn2, new GazeAwareBehavior(OnBtn2_Click) { DelayMilliseconds = buttonClickDelay });                      
            bhavHomeControlPageMap.Add(btn3, new GazeAwareBehavior(OnBtn3_Click) { DelayMilliseconds = buttonClickDelay });

            bhavHomeControlPageMap.Add(pnl1, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavHomeControlPageMap.Add(pnl2, new GazeAwareBehavior(OnGazeChangeBTColour));
            bhavHomeControlPageMap.Add(pnl3, new GazeAwareBehavior(OnGazeChangeBTColour));           
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

        private void OnbtnHomeCancel_Click(object sender, GazeAwareEventArgs e)
        {
            btnHomeCancel.PerformClick();
        }
        private void OnBtn1_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btn1.PerformClick();
        }
        private void OnBtn2_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btn2.PerformClick();
        }

        private void OnBtn3_Click(object sender, GazeAwareEventArgs e)
        {
            if (e.HasGaze) btn3.PerformClick();
        }        
    }
}
