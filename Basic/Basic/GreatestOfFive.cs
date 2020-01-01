using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    public class GreatestOfFive
    {
        public int Max(int a, int b, int c, int d, int e)
        {
            int maxim = a;
            if (b > maxim) maxim = b;
            if (c > maxim) maxim = c;
            if (d > maxim) maxim = d;
            if (e > maxim) maxim = e;

            return maxim;

        }
    }
}
