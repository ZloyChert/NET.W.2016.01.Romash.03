using System;
using System.Collections;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task4.Tests
{
    [TestClass]
    public class DoubleExtensionTests
    {
        [TestMethod]
        public void GetBitArray_155dot625()
        {
            double number = 155.625;
            bool[] res = number.GetBitArray();

            bool[] ar =
            {
                false, true, false, false, false, false, true, true, false, false, false, true, true, false,
                true, true, true, false, true, false, false, false, false, false, false, false, false, false, false,
                false, false, false
            };
            Assert.AreEqual(res, ar);
        }
    }
}
