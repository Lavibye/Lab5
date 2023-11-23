using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class SeriesCalculator : ISeriesCalculator
    {
        public double CalculateSeriesWithLoop(double x, int iterations)
        {
            double result = Math.PI / 2;

            for (int n = 1; n <= iterations; n++)
            {
                result -= (Math.Pow(-1, n) / Math.Pow((2 * n - 1), 2)) * Math.Cos((2 * n - 1) * x);
            }

            return result;
        }

        public double CalculateSeriesWithRecursion(double x, int n)
        {
            if (n == 0)
            {
                return Math.PI / 2;
            }

            return CalculateSeriesWithRecursion(x, n - 1) - (Math.Pow(-1, n) / Math.Pow((2 * n - 1), 2)) * Math.Cos((2 * n - 1) * x);
        }
    }
}
