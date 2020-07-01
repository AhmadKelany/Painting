using Painting.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Painting
{
    public static class GraphicsExtensions
    {
        public static void DrawPattern(this Graphics graphics,
                                       Point centerPoint,
                                       Pen pen,
                                       int axiesCount,
                                       int step,
                                       int firstDiagonal,
                                       int secondDiagonal)
        {
            var firstPoints = MathHelper.GetPoints(firstDiagonal, axiesCount, centerPoint);
            var secondPoints = MathHelper.GetPoints(secondDiagonal, axiesCount, centerPoint);
            var headsCount = firstPoints.Count;

            for (int h = 0; h < headsCount; h++)
            {
                var headPoint = firstPoints[h];
                var frontPointIndex = h + step <= headsCount - 1 ? h + step : h + step - headsCount;
                var backPointIndex = h - step >= 0 ? h - step : headsCount - step+ h;
                graphics.DrawLine(pen, headPoint, secondPoints[frontPointIndex]);
                graphics.DrawLine(pen, headPoint, secondPoints[backPointIndex]);
            }
        }

        public static void DrawPattern(this Graphics graphics,
                                       Point centerPoint,
                                       PatternControl control)
        {
            graphics.DrawPattern(centerPoint,
                new Pen(control.LinesColor, control.LineThickness),
                control.AxiesCount,
                control.Step,
                control.Diagonal1,
                control.Diagonal2);
        }
    }
}
