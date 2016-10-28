

using System;
using NUnit.Framework;

namespace Task3.NUnitTests
{
    [TestFixture]
    public class MathematicNUnitTests
    {
        [TestCase(125, 3, 0.01)]
        [TestCase(125, 2, 0.01)]
        [TestCase(125, 4, 0.01)]
        [TestCase(125, 5, 0.01)]
        public void NutonSqrt_Test(double number, int exp, double eps)
        {
            Assert.AreEqual(Mathematic.NutonSqrt(number, exp, eps), Math.Pow(number, (1 /(double)exp)), eps);
        }
    }
}
