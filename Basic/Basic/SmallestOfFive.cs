using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    public class SmallestOfFive
    {
        public int Min(int a, int b, int c, int d, int e)
        {
        int minim = a;
        if (b < minim) minim = b;
        if (c < minim) minim = c;
        if (d < minim) minim = d;
        if (e < minim) minim = e;

        return minim;

        }
    }
}
