using System;
using System.Collections.Generic;
using MathNet.Numerics.Distributions;

namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public class Generator : DimensionBase
    {
        // only 1 instance per app
        private static readonly Random _random = new Random();
        private static readonly DateTime _baseDate = new DateTime(1980, 01, 01);


        public int MinValue { get; set; }
        public int MaxValue { get; set; }

        public static int GetRandomValue(int min, int max) => _random.Next(min, max);
        public static int GetRandomValue(int delta) => _random.Next(delta * -1, delta);

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
        public static IEnumerable<double> GetNormalValues(double mean, double stdDev, int n)
        {
            Normal normalDistr = new Normal(mean, stdDev, _random);
            List<double> list = new();
            for (int i = 0; i < n; i++)
            {
                list.Add(normalDistr.Sample());
            }
            return list;
        }

        public static int GetNormalId(int maxId)
        {
            double mean = maxId / 2;    // medium value
            double stdDev = maxId / 6;  // assume 6sigma borders
            int fetchedId = (int)GetNormalValue(mean, stdDev);
            if (fetchedId < 1)
                fetchedId = 1;
            if (fetchedId > maxId)
                fetchedId = maxId;
            return fetchedId;
        }


        public static DateTime GetRandomDate(int deltaDays, DateTime baseDate) => baseDate.AddDays(GetRandomValue(deltaDays));
        public static DateTime GetRandomDate(int deltaDays) => GetRandomDate(deltaDays, _baseDate);


        // currently not working, the enumeration is emtpy. do not use
        public static IEnumerable<double> GetNormalValues_DEPR(double mean, double stdDev)
        {
            Normal normalDistr = new Normal(mean, stdDev, _random);
            return normalDistr.Samples();
        }
    }
}
