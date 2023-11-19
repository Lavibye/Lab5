using Lab5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class SeriesCalculatorTests
    {
        [TestMethod]
        public void TestSeriesCalculationWithLoop()
        {
            double x = 1.0;
            int iterations = 5;

            double result = SeriesCalculator.CalculateSeriesWithLoop(x, iterations);

            Assert.AreEqual(0.214779, result, 0.000001);
        }

        [TestMethod]
        public void TestSeriesCalculationWithRecursion()
        {
            double x = 1.0;
            int iterations = 5;

            double result = SeriesCalculator.CalculateSeriesWithRecursion(x, iterations);

            Assert.AreEqual(0.214779, result, 0.000001);
        }
    }
}
