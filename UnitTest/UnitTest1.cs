using Lab5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class SeriesCalculatorTests
    {
        private ISeriesCalculator seriesCalculator;

        [TestInitialize]
        public void Setup()
        {
            seriesCalculator = new SeriesCalculator();
        }

        [TestMethod]
        public void TestSeriesCalculationWithLoop()
        {
            double x = 1.0;
            int iterations = 5;

            double result = seriesCalculator.CalculateSeriesWithLoop(x, iterations);

            Assert.AreEqual(2.20581000432612, result, 0.000001);
        }

        [TestMethod]
        public void TestSeriesCalculationWithRecursion()
        {
            double x = 1.0;
            int iterations = 5;

            double result = seriesCalculator.CalculateSeriesWithRecursion(x, iterations);

            Assert.AreEqual(2.20581000432612, result, 0.000001);
        }
    }
}