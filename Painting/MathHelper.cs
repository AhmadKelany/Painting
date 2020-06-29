using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Painting
{
    public class MathHelper
    {
        public static Displacement GetDisplacement(decimal angle, int diagonal)
        {
            if (angle < 0.0m || angle > 90.0m)
            {
                throw new ArgumentOutOfRangeException(nameof(angle), "The angle should be between 0 and 90");
            }
            var result = new Displacement();
            result.Horizontal = (decimal)(diagonal * Math.Sin((double)angle * 0.01745329));
            result.Vertical = (decimal)Math.Sqrt(Math.Pow(diagonal , 2) - Math.Pow((double)result.Horizontal , 2));

            return result;
        }

        public static List<decimal> GetAngles(int axiesCount)
        {
            var result = new List<decimal>();
            var count = (decimal) (axiesCount / 2.0);
            var angleStep =(decimal) (90.0m / count);
            for (int i = 0; i < count-1; i++)
            {
                result.Add(angleStep + (i * angleStep));
            }

            return result;
        }
        public static Point DisplacePoint(Point point , Point centerPoint ,  int quarter)
        {

        }

        public static List<Point> GetPoints(int diagonal , int axiesCount , Point centerPoint)
        {
            var uniquePointsCount = (axiesCount / 2) - 1;
            var angles = GetAngles(axiesCount);

            // first quarter


            // second quarter

            // third quarter

            // fourth quarter


        }
    }
}
