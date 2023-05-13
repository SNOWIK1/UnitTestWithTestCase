using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyMathNamespace;

namespace MathUnitTest
{
    [TestClass]
    public class CalculateTest
    {
        [TestMethod]
        public void Volume_3_27returned()
        {
            string a = "3";
            double expected = 27;

            double actual = MyMath.Volume(a);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Volume_double23_double12167returned()
        {  
            string b = "2,3";
            double expected1 = 12.167;

            double actual1 = MyMath.Volume(b);

            Assert.AreEqual(expected1, actual1);
        }
    }
}
