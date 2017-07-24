using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GazeToolBar
{
    public class Utils
    {
        /*
         *  An easy utility for printing several values at once
         *  Usage:
         *      Print("First Value", x, y, z, GetPosition());
         */
        public static void Print(params Object[] toPrint)
        {
            String outString = "";
            foreach (Object o in toPrint)
            {
                outString += o.ToString() + " ";
            }

            Console.WriteLine(outString);
        }

        /*
         * Adds two points together and returns the result
         */
        public static Point AddPoints(Point a, Point b)
        {
            int fX = a.X + b.X;
            int fY = a.Y + b.Y;

            return new Point(fX, fY);
        }

        /*
         *  Subtracts two points and returns the result
         */
        public static Point SubtractPoints(Point a, Point b)
        {
            int fX = a.X - b.X;
            int fY = a.Y - b.Y;

            return new Point(fX, fY);
        }

        /*
         *  Divides the x and y point by the divideAmount
         *  Note: this is integer division
         */
        public static Point DividePoint(Point p, int divideAmount)
        {
            int fX = p.X / divideAmount;
            int fY = p.Y / divideAmount;

            return new Point(fX, fY);
        }
    }
}
