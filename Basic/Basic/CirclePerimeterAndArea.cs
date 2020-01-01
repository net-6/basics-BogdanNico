using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class CirclePerimeterAndArea
    {
        public double CirclePerimeter(double radius, double pi)
        {
            return 2 * pi * radius;
        }

        public double CircleArea(double radius, double pi)
        {
            return pi * radius * radius;
        }
    }
}
