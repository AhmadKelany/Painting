using System;
using System.Collections.Generic;
using Xunit;

namespace Painting.Tests
{
    public class MathTests
    {
        [Theory]
        [InlineData(30, 5, 4.33013, 2.5)]
        [InlineData(40, 10, 7.6604, 6.42788)]
        [InlineData(60, 15 , 7.5, 12.99038)]
        [InlineData(20, 9, 8.45723, 3.07818)]
        public static void GetDisplacementTest(decimal angle, int diagonal, decimal vertical, decimal horizontal)
        {
            var displacememt = MathHelper.GetDisplacement(angle, diagonal);
            Assert.Equal(vertical.ToString("0.00"), displacememt.Vertical.ToString("0.00"));
            Assert.Equal(horizontal.ToString("0.00"), displacememt.Horizontal.ToString("0.00"));
        }

        [Fact]
        public static void GetAngles()
        {
            var angles = MathHelper.GetAngles(8);
            Assert.Equal(new List<decimal>() { 22.5m, 45m, 67.50m }, angles);

            var ps = MathHelper.GetPoints(80, 16, new System.Drawing.Point(100, 100));
        }
    }
}
