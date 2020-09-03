using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class RandomeCS
    {
        public static int IntRandom(int length = 6)
        {
            if (length < 1)
                return int.MinValue;
            string str = string.Empty;
            Random random = new Random();
            for (int i = 0; i < length; i++)
                str += random.Next(0, 9).ToString();
            return Convert.ToInt32(str);
        }
        //todo Check Random Code
        //Errors
        //000000
        //123456
    }
}
