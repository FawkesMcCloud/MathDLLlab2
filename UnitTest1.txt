using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class MathUnitTest
    {
        [TestMethod]
        public void Addition()
        {
            Assert.AreEqual( 0, MathLab2.Add(0, 0),0.1);
            Assert.AreEqual(1, MathLab2.Add(0, 1), 0.1);
            Assert.AreEqual( 2, MathLab2.Add(0, 2));
            Assert.AreEqual( -1, MathLab2.Add(0, -1));
            Assert.AreEqual(-2, MathLab2.Add(-1, -1));
            Assert.AreEqual(0, MathLab2.Add(-1, 1));

            Assert.AreEqual(0.0, MathLab2.Add(0.0, 0.0));
        }

        [TestMethod]
        public void Substraction()
        {
            Assert.AreEqual(0, MathLab2.Sub(0, 0));
            Assert.AreEqual(1, MathLab2.Sub(0, -1));
            Assert.AreEqual(-1, MathLab2.Sub(0, 1));
            Assert.AreEqual( 0, MathLab2.Sub(-1, -1));
        }

        [TestMethod]
        public void Multiplication()
        {
            Assert.AreEqual( 0, MathLab2.Mul(0, 0));
            Assert.AreEqual(0, MathLab2.Mul(0, 1));
            Assert.AreEqual(1,MathLab2.Mul(1, 1));
            Assert.AreEqual(-1, MathLab2.Mul(1, -1));
            Assert.AreEqual(0, MathLab2.Mul(2, 0));
        }

        [TestMethod]
        public void Division()
        {
            Assert.AreEqual(double.NaN, MathLab2.Div(0, 0));
            Assert.AreEqual(double.NaN, MathLab2.Div(1, 0));
            Assert.AreEqual(1, MathLab2.Div(1, 1),0.1);
            Assert.AreEqual(0.5, MathLab2.Div(1, 2), 0.1);
        }

        [TestMethod]
        public void Power()
        {
            Assert.AreEqual(double.NaN, MathLab2.Pow(0, 0));
            Assert.AreEqual( 0, MathLab2.Pow(0, 1), 0.1);
            Assert.AreEqual( 1, MathLab2.Pow(1, 2), 0.1);
            Assert.AreEqual(2, MathLab2.Pow(2, 1), 0.1);
            Assert.AreEqual(4, MathLab2.Pow(2, 2), 0.1);
            Assert.AreEqual(1, MathLab2.Pow(2, 0), 0.1);
            Assert.AreEqual( 1.0 / 4.0, MathLab2.Pow(2, -2), 0.1);
        }

        [TestMethod]
        public void AbsoluteVal()
        {
            Assert.AreEqual( 0, MathLab2.Abs(0));
            Assert.AreEqual( 1, MathLab2.Abs(1));
            Assert.AreEqual( 1, MathLab2.Abs(-1));
        }

        [TestMethod]
        public void Triags()
        {
            Assert.AreEqual(0.5, MathLab2.TriagArea(1, 1), 0.1);
            Assert.AreEqual(1, MathLab2.TriagArea(1.0353, 2, 2), 0.1);
            Assert.AreEqual(0.5, MathLab2.TriagArea(1, 1, new Angle(90)), 0.1);

            Assert.AreEqual(3, MathLab2.TriagPerimiter(1, 1, 1), 0.1);

        }

        [TestMethod]
        public void Ellipses()
        {
            Assert.AreEqual(0, MathLab2.Circumference(0), 0.1);
            Assert.AreEqual(3.14, MathLab2.Circumference(0.5), 0.1);

            Assert.AreEqual(3.14, MathLab2.CircleArea(1), 0.1);

            Assert.AreEqual(3.14,MathLab2.EllipseArea(1, 1), 0.1);
            Assert.AreEqual(MathLab2.EllipseArea(1, 1), MathLab2.CircleArea(1), 0.1);

            Assert.AreEqual(0, MathLab2.Eccentricity(1, 1), 0.1);
            Assert.AreEqual(0.866, MathLab2.Eccentricity(1, 2), 0.1);

            Assert.AreEqual(0.0, MathLab2.LinearEccentricity(1, 1), 0.1);

        }


    }
}
