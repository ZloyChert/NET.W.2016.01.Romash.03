﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class Mathematic
    {
        /// <summary>
        /// Mathematical radical
        /// </summary>
        /// <param name="number">Number to count</param>
        /// <param name="exp">Exponent</param>
        /// <param name="eps">Сorrectness</param>
        /// <returns></returns>
        public static double NutonSqrt(double number, int exp, double eps)
        {
            double x, xn = 5;
            do
            {
                x = xn;
                xn = ((exp - 1)*x + number/Math.Pow(x, number - 1))/exp;
            } while (Math.Abs(Math.Pow(xn, exp) - number) > eps);
            return xn;
        }
    }
}
