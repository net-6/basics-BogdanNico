using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    public class NumbersBetween
    {
        public int HowManyNumbersBetween(int min, int max, int counter = 0)
        {
            for (int i = min; i <= max; i = i + 1)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            return counter;
        }

    }
}
