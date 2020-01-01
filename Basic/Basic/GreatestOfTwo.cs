using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class GreatestOfTwo
    {
        public int GreatestWithoutConditional(int a, int b)
        {
            return Math.Max(a, b);
        }

        public int GreatestWithConditional(int a, int b)
        {
            if (a>b) { return a; } else { return b; }
        }
    }
}
