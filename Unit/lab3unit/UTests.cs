using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace lab3unit
{
    [TestFixture]
    class UTests
    {
        [Test]
        public void Test1()
        {
            TriangleSides triangle = new TriangleSides();
            Assert.IsTrue(triangle.Sides(20, 10, 30));
        }

        [Test]
        public void Test2()
        {
            TriangleSides triangle = new TriangleSides();
            Assert.IsTrue(triangle.Sides(1, 1, 1));
        }

        [Test]
        public void Test3()
        {
            TriangleSides triangle = new TriangleSides();
            Assert.IsFalse(triangle.Sides(-1, 1, 20));
        }

        [Test]
        public void Test4()
        {
            TriangleSides triangle = new TriangleSides();
            Assert.IsFalse(triangle.Sides(0, 0, 0));
        }

        [Test]
        public void Test5()
        {
            TriangleSides triangle = new TriangleSides();
            Assert.IsFalse(triangle.Sides(4.9, 0.3, 5.4));
        }

        [Test]
        public void Test6()
        {
            TriangleSides triangle = new TriangleSides();
            Assert.IsFalse(triangle.Sides(10, 100, 200));
        }

        [Test]
        public void Test7()
        {
            TriangleSides triangle = new TriangleSides();
            Assert.IsFalse(triangle.Sides(-356, -194, -35));
        }

        [Test]
        public void Test8()
        {
            TriangleSides triangle = new TriangleSides();
            Assert.IsFalse(triangle.Sides(129, 0.89,2566));
        }

        [Test]
        public void Test9()
        {
            TriangleSides triangle = new TriangleSides();
            Assert.IsFalse(triangle.Sides(98, 90, 5));
        }

        [Test]
        public void Test10()
        {
            TriangleSides triangle = new TriangleSides();
            Assert.IsFalse(triangle.Sides(-100, -112, 1));
        }
    }
}
