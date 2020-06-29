using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            var vertical = centerPoint.Y - point.Y;
            var horizontal = point.X - centerPoint.X;
            int x = 0;
            int y = 0;

            switch (quarter)
            {
                case 2:
                    x = centerPoint.X + horizontal;
                    y = centerPoint.Y + vertical;
                    break;
                case 3:
                    x = centerPoint.X - horizontal;
                    y = centerPoint.Y + vertical;
                    break;
                case 4:
                    x = centerPoint.X - horizontal;
                    y = centerPoint.Y - vertical;
                    break;
                default:
                    break;
            }
            return new Point(x, y);
        }

        public static List<Point> GetPoints(int diagonal , int axiesCount , Point centerPoint)
        {
            var angles = GetAngles(axiesCount);
            var result = new List<Point>();

            result.Add(new Point(centerPoint.X, centerPoint.Y - diagonal));
            foreach (var angle in angles)
            {
                var displacement = GetDisplacement(angle, diagonal);
                result.Add(new Point(centerPoint.X + (int)displacement.Horizontal, centerPoint.Y - (int)displacement.Vertical));
            }
            result.Add(new Point(centerPoint.X + diagonal, centerPoint.Y));

            var count = result.Count - 2;
            DisplaceQuarter(centerPoint, result, count , 2);
            result.Add(new Point(centerPoint.X, centerPoint.Y + diagonal));
            DisplaceQuarter(centerPoint, result, count, 3);
            result.Add(new Point(centerPoint.X - diagonal, centerPoint.Y));
            DisplaceQuarter(centerPoint, result, count, 4);

            return result;
        }

        private static void DisplaceQuarter(Point centerPoint, List<Point> result, int count , int quarter)
        {
            if (quarter == 3)
            {
                for (int i = 1; i <= count; i++)
                {
                    result.Add(DisplacePoint(result[i], centerPoint, quarter));
                }

            }
            else
            {
                for (int i = count; i >= 1; i--)
                {
                    result.Add(DisplacePoint(result[i], centerPoint, quarter));
                }

            }
        }
    }
}
