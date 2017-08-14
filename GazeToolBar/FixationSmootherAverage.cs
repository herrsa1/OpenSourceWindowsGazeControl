using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GazeToolBar
{
    public class FixationSmootherAverage : FixationSmootherBase
    {
        int bufferCurrentIndex;
        int bufferFullIndex;

        public FixationSmootherAverage(int BufferSize) : base(BufferSize)
        {
            bufferCurrentIndex = 0;
            bufferFullIndex = 0;
        }

        public override void AddCoordinateToBuffer(double x, double y)
        {

            if (bufferCurrentIndex == bufferSize)
            {
                bufferCurrentIndex = 0;
            }

            if (bufferFullIndex != bufferSize)
            {
                bufferFullIndex++;
            }

            xBuffer[bufferCurrentIndex] = x;
            yBuffer[bufferCurrentIndex] = y;

            bufferCurrentIndex++;
        }

        public override GazePoint SmoothPointsFromBuffer()
        {
            GazePoint returnSmoothPoint = new GazePoint(0, 0);
            double xTotal = 0;
            double yTotal = 0;

            for (int arrayIndex = 0; arrayIndex < bufferFullIndex; arrayIndex++)
            {
                xTotal += xBuffer[arrayIndex];
                yTotal += yBuffer[arrayIndex];
            }

            returnSmoothPoint.X = xTotal / bufferFullIndex;
            returnSmoothPoint.Y = yTotal / bufferFullIndex;

            return returnSmoothPoint;

        }
    }
}
