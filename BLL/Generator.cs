using System;
using System.Collections.Generic;
using System.Linq;
using MathNet.Numerics.Distributions;
using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataGenerator.DAL;
using Rki.CancerDataGenerator.Models;
using Rki.CancerDataGenerator.Models.ADTGEKID;

namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public class Generator : DimensionBase, IGenerator
    {
        private AdtGekidDbContext _context { get; }

        private readonly Random _random = new Random();

        private Configuration _config { get; }

        public Generator(AdtGekidDbContext context)
        {
            _context = context;
            _context.Init();
            _config = new Configuration();
        }


        private int createRandomValue(int min, int max) => _random.Next(min, max + 1);
        private int createRandomValue(int delta) => _random.Next(delta * -1, delta);

        private double createNormalValue(double mean, double stdDev)
        {
            Normal normalDistr = new Normal(mean, stdDev, _random);
            return normalDistr.Sample();
        }


        public int CreateNormalValue(int min, int max)
        {
            double mean = max / 2;    // medium value
            double stdDev = max / 6;  // assume 6sigma borders
            int fetchedId = (int)createNormalValue(mean, stdDev);
            if (fetchedId < min)
                fetchedId = min;
            if (fetchedId > max)
                fetchedId = max;
            return fetchedId;
        }

        private DateTime createRandomDate(int deltaDays, DateTime baseDate) => baseDate.AddDays(createRandomValue(deltaDays));

        private T getRandomEnumItem<T>() where T : Enum
        {
            var array = Enum.GetValues(typeof(T));
            return (T)array.GetValue(_random.Next(array.Length));
        }

        private T getNormalDimensionItem<T>() where T : DimensionBase
        {
            int count = _context.GetAll<T>().Count();
            // have index range (0, n-1) instead of id (1,n)
            var rng = CreateNormalValue(0, count - 1);
            return _context.GetByIndex<T>(rng);
        }


        private T getRandomDimensionItem<T>() where T : DimensionBase
        {
            var count = _context.GetAll<T>().Count();
            var rng = createRandomValue(0, count - 1);
            return _context.GetByIndex<T>(rng);
        }


        /* specific*/
        public Quote FetchRandomDimensionItem_Quote()
        {
            if (_random.NextDouble() < _config.Text_ProbMissing)
                return null;
            return getRandomDimensionItem<Quote>();
        }

        public Icd FetchNormalDimensionItem_Icd()
        {
            if (_random.NextDouble() < _config.Icd_ProbMissing)
                return null;
            return getNormalDimensionItem<Icd>();
        }

        public ICD_Version_Typ FetchRandomEnumItem_IcdVersion()
        {
            if (_random.NextDouble() < _config.IcdVersion_ProbMissing)
                return ICD_Version_Typ.None;
            return getRandomEnumItem<ICD_Version_Typ>();
        }

        public int CreateFixedValuePatientCount() => _config.Patient_Count;

        public DateTime CreateRandomDate_Meldedatum() => createRandomDate(10 * 365, _config.Meldedatum_BaseDate);
        public DateTime CreateRandomDate_Geburtsdatum() => createRandomDate(40 * 365, new DateTime(1970, 01, 01));

        public int GetDaysToPublishDate(DateTime start) => (_config.PublishDate - start).Days;
        public int GetYearsToPublishDate(DateTime start) => GetDaysToPublishDate(start) / 365;

        public int GetMeldungCountPerAge(int age)
        {
            if (age < 30) 
                return 1;
            if (age < 50)
                return 2;
            return 3;
        }

    }
}
