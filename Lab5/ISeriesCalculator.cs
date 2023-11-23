using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public interface ISeriesCalculator
    {
        double CalculateSeriesWithLoop(double x, int iterations);
        double CalculateSeriesWithRecursion(double x, int n);
    }
}
