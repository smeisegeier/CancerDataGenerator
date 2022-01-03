using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.Distributions;
using Rki.CancerDataGenerator.DAL;

namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public class Generator : DimensionBase, IGenerator
    {
        private AdtGekidDbContext _context { get; }

        private readonly Random _random = new Random();
        private readonly DateTime _baseDate = new DateTime(1980, 01, 01);

        public Generator(AdtGekidDbContext context)
        {
            _context = context;
            _context.Init();
        }


        public int CreateRandomValue(int min, int max) => _random.Next(min, max + 1);
        public int CreateRandomValue(int delta) => _random.Next(delta * -1, delta);

        public double CreateNormalValue(double mean, double stdDev)
        {
            Normal normalDistr = new Normal(mean, stdDev, _random);
            return normalDistr.Sample();
        }


        public int CreateNormalValue(int min, int max)
        {
            double mean = max / 2;    // medium value
            double stdDev = max / 6;  // assume 6sigma borders
            int fetchedId = (int)CreateNormalValue(mean, stdDev);
            if (fetchedId < min)
                fetchedId = min;
            if (fetchedId > max)
                fetchedId = max;
            return fetchedId;
        }

        /// <summary>
        /// Picks DateTime from random spread.
        /// </summary>
        /// <param name="deltaDays">day range borders around basedate</param>
        /// <param name="baseDate">eg. 1.1.1980</param>
        /// <returns></returns>
        public DateTime CreateRandomDate(int deltaDays, DateTime baseDate) => baseDate.AddDays(CreateRandomValue(deltaDays));
        public DateTime CreateRandomDate(int deltaDays) => CreateRandomDate(deltaDays, _baseDate);


        public T GetRandomEnumItem<T>() where T : Enum
        {
            var array = Enum.GetValues(typeof(T));
            return (T)array.GetValue(_random.Next(array.Length));
        }

        public T GetNormalDimensionItem<T>() where T : DimensionBase
        {
            int count = _context.GetAll<T>().Count();
            // have index range (0, n-1) instead of id (1,n)
            var rng = CreateNormalValue(0, count - 1);
            return _context.GetByIndex<T>(rng);
        }


        public T GetRandomDimensionItem<T>() where T : DimensionBase
        {
            var count = _context.GetAll<T>().Count();
            var rng = CreateRandomValue(0, count - 1);
            return _context.GetByIndex<T>(rng);
        }

    }
}
