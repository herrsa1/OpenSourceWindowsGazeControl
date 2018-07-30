using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GazeToolBar
{
    public class SettingJSON
    {
        public int fixationTimeLength { get; set; }
        public int fixationTimeOut { get; set; }
        public string leftClick { get; set; }
        public string doubleClick { get; set; }
        public string rightClick { get; set; }
        public string scoll { get; set; }
        public string micInput { get; set; }
        public string micInputOff { get; set; }
        public string[] sidebar { get; set; }
        public int maxZoom { get; set; }
        public int Crosshair { get; set; }
        public int zoomWindowSize { get; set; }
        public bool stickyLeftClick { get; set; }
        public bool selectionFeedback { get; set; }
        public string[] homeLables { get; set; }
        public int?[] buttonDeviceNumbers { get; set; }
        public HomeControlPage.ButtonType[] homeButtonTypes { get; set; }
    }
}
