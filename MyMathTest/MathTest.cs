using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMath;
namespace MyMathTest
{
    [TestClass]
    public class MathTest
    {
        MyMath.Math math = new MyMath.Math();

        [TestMethod]
        public void AddTest()
        {
            Assert.IsTrue(math.Add(1, 2) == 3);
        }

        [TestMethod]
        public void AddTestNegativeNumber()
        {
            Assert.AreEqual(math.Add(-3, -4), -7);
        }

        [TestMethod]
        public void AddTestDoubleNumber()
        {
            Assert.AreEqual(math.Add(3.5, 3.5), 7);
        }

        [TestMethod]
        public void SubstracIntTest()
        {
            Assert.AreEqual(math.Substract(2, 2), 0);
        }

        [TestMethod]
        public void SubstractDoubleTest()
        {
            Assert.AreEqual(math.Substract(1.5, 1.5), 0);
        }

        [TestMethod]
        public void SubstracTStringTest()
        {
            Assert.AreEqual(math.Substract("2","2"), 0);
        }

        [TestMethod]
        public void MultiplyIntTest()
        {
            Assert.AreEqual(math.Multiply(2,2), 4);
        }

        [TestMethod]
        public void MultiplyDoubleTest()
        {
            Assert.AreEqual(math.Multiply(2.5, 2), 5);
        }

    }
}
