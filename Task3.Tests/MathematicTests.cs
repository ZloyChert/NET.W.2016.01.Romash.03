using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3.Tests
{
    [TestClass]
    public class MathematicTests
    {
        [TestMethod]
        public void NutonSqrt_Number125Exp3_5Return()
        {
            double result = Mathematic.NutonSqrt(125, 3, 0.01);
            Assert.AreEqual(result, 5, 0.01);
        }

        [TestMethod]
        public void NutonSqrt_Number625Exp4_5Return()
        {
            double result = Mathematic.NutonSqrt(625, 4, 0.01);
            Assert.AreEqual(result, 5, 0.01);
        }


    }
}
