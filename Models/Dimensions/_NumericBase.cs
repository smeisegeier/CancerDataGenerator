using System;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;

namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public class _NumericBase : _DimensionBase
    {
        // only 1 instance per app
        private static readonly Random _random = new Random();
     
        public int MinValue { get; set; }
        public int MaxValue { get; set; }

        public static int GetRandomValue(int min, int max) => _random.Next(min, max);

        public static IEnumerable<int> GetRandomValues(int min, int max, int n)
        {
            List<int> list = new();
            for (int i = 0; i < n; i++)
            {
                list.Add(GetRandomValue(min, max));
            }
            return list;
        }

        public static double GetNormalValue(double mean, double stdDev)
        {
            Normal normalDistr = new Normal(mean, stdDev, _random);
            return normalDistr.Sample();
        }

        public static IEnumerable<double> GetNormalValues(double mean, double stdDev)
        {
            Normal normalDistr = new Normal(mean, stdDev, _random);
            return normalDistr.Samples();
        }
    }
}
