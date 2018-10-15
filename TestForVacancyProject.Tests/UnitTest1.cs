using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;


namespace TestForVacancyProject.Tests
{
    [TestClass]
    public class MainClassTest
    {
        List<object> paramList = new List<object>();
        BaseAreaCounter BaseArea = new BaseAreaCounter();

        [TestMethod]
        public void TriangleAreaTest()
        {
            double a = 5;
            double b = 6.5;
            double c = 7;

            paramList.Add(a);
            paramList.Add(b);
            paramList.Add(c);

            var actual = BaseArea.Count(paramList);
            var expected = 15.6;

            Assert.AreEqual(expected, actual);
            paramList.Clear();
        }

        [TestMethod]
        public void RoundAreaTest()
        {
            double radius = 6;
            paramList.Add(radius);

            var actual = BaseArea.Count(paramList);
            var expected = 113.09;

            Assert.AreEqual(expected, actual);
            paramList.Clear();
        }

        [TestMethod]
        public void AnyAreaTest()
        {
            Point[] dots = new[] { new Point(5, 1), new Point(0, 1), new Point(8, 8) };
            paramList.Add(dots);

            var expected = 17.5;
            var actual = BaseArea.Count(paramList);
            Assert.AreEqual(expected, actual);
            paramList.Clear();
        }

        [TestMethod]
        public void CheckRightTriangle()
        {
            double a = 7;
            double b = 12.124;
            double c = 14;

            paramList.Add(a);
            paramList.Add(b);
            paramList.Add(c);
            paramList.Add(true);

            var actual = BaseArea.Count(paramList);
            var expected = new Tuple<double, bool>(42.43, true);

            Assert.AreEqual(expected, actual);
            paramList.Clear();
        }
    }
}
