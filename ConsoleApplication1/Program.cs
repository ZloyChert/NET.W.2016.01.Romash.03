using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 155.625;
            bool[] bits = new bool[32];
            bool[] mantiss1 = new bool[(int)Math.Log(number, 2) + 1];
            bool[] mantiss2 = new bool[23 - mantiss1.Length];
            bits[0] = Math.Sign(number) < 0;

            int integ = (int)number;
            double end = number - integ;
            int k = (int)Math.Log(number, 2);

            while (integ > 0)
            {
                mantiss1[k] = integ % 2 == 1;
                integ = integ / 2;
                k--;
            }
            int i = -1;
            k = 0;
            while (k < mantiss2.Length - 1)
            {
                if (Math.Pow(2, i) <= end)
                {
                    mantiss2[k] = true;
                    end = end - Math.Pow(2, i);
                }
                else
                    mantiss2[k] = false;

                k++;
                i--;
            }
            int exponenta = (int)Math.Log(number,2) + 127;
            int j = 8;
            while (exponenta > 0)
            {
                bits[j] = exponenta % 2 == 1;
                exponenta = exponenta / 2;
                j--;
            }
            j = 0;
            for (int g = 1; g < mantiss1.Length; g++)
            {
                bits[g + 8] = mantiss1[g];
            }
            for (int g = 0; g < mantiss2.Length; g++)
            {
                bits[g + 9 + mantiss1.Length] = mantiss2[g];
            }

            for (int g = 0; g < bits.Length; g++)
            {
                Console.Write(bits[g] + " ");
            }
            Console.ReadLine();
        }
    }
}
