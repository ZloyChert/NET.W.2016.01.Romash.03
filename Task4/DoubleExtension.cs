using System;
using System.Collections;

namespace Task4
{
    public static class DoubleExtension
    {
        public static BitArray GetBitArray(this double number)
        {
            bool[] bits = new bool[32];
            bool[] mantiss = new bool[23];
            bits[0] = Math.Sign(number) < 0;

            int integ = (int) number;
            double end = number - integ;
            int k = 0;

            while (integ > 1)
            {
                mantiss[k] = integ % 2 == 1;
                integ = integ/2;
                k++;
            }
            int i = -1;
            while (k < 23)
            {
                if (Math.Pow(2, i) < end)
                {
                    mantiss[k] = true;
                    end = end - Math.Pow(2, i);
                }
                else
                    mantiss[k] = false;

                k++;
                i--;
            }
            int exponenta = (int)Math.Log(number) + 127;
            int j = 8;
            while (exponenta > 1)
            {
                bits[j] = exponenta % 2 == 1;
                exponenta = exponenta / 2;
                j--;
            }
            j = 0;
            for (int g = 31; g > 8; g--)
            {
                bits[g] = mantiss[j];
                j++;
            }

            return new BitArray(bits);
        }
    }
}
