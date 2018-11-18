using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        CheckTriangle.CheckTriangle tringle = new CheckTriangle.CheckTriangle();
        [TestMethod]
        public void AllSidesAreNegative()
        {
            Assert.AreEqual(true, tringle.IsTriangle(-12,-4,-7));
        }
        [TestMethod]
        public void AllSidesAreNegativeFalse()
        {
            Assert.AreEqual(false, tringle.IsTriangle(-12, -4, -7));
        }
        [TestMethod]
        public void AllSidesAreMaxDouble()
        {
            Assert.AreEqual(true, tringle.IsTriangle(double.MaxValue, double.MaxValue, double.MaxValue));
        }
        [TestMethod]
        public void AllSidesAreMaxDoubleFalse()
        {
            Assert.AreEqual(false, tringle.IsTriangle(double.MaxValue, double.MaxValue, double.MaxValue));
        }
        [TestMethod]
        public void AllSidesAreNormal()
        {
            Assert.AreEqual(true, tringle.IsTriangle(20, 10, 11));
        }
        [TestMethod]
        public void AllSidesAreNormalFalse()
        {
            Assert.AreEqual(false, tringle.IsTriangle(20, 10, 11));
        }
        [TestMethod]
        public void AllSidesAreDoubleMinValue()
        {
            Assert.AreEqual(true, tringle.IsTriangle(double.MinValue, double.MinValue, double.MinValue));
        }
        [TestMethod]
        public void AllSidesAreDoubleMinValueFalse()
        {
            Assert.AreEqual(false, tringle.IsTriangle(double.MinValue, double.MinValue, double.MinValue));
        }
        [TestMethod]
        public void AllSidesAreNaN()
        {
            Assert.AreEqual(true, tringle.IsTriangle(double.NaN, double.NaN, double.NaN));
        }
        [TestMethod]
        public void AllSidesAreNaNFalse()
        {
            Assert.AreEqual(false, tringle.IsTriangle(double.NaN, double.NaN, double.NaN));
        }
    }
}
