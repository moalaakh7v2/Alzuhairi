using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class RandomeCS
    {
        static Random random = new Random();
        public static int IntRandom(int length = 6)
        {
            if (length < 1)
                return int.MinValue;
            int min = (int)Math.Pow(10, length - 1);
            int max = min * 10 - 1;
            return random.Next(min, max);
        }
    }
}
