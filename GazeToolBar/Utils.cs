using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GazeToolBar
{
    public class Utils
    {
        public static void print(params Object[] toPrint)
        {
            print(" ", toPrint);
        }

        public static void print(String seperator, params Object[] toPrint)
        {
            String outString = "";
            foreach (Object o in toPrint)
            {
                outString += o.ToString() + seperator;
            }
        }
    }
}
