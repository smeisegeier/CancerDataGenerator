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
    /// <summary>
    /// This class summarizes all items to generate random data in various distributions (random, normal)
    /// Glossary:
    /// - get -> 
    /// - fetch -> fetch an existing entry following random spread
    /// - create -> create a random entry from scratch
    /// </summary>
    public class Generator : DimensionBase      //, IGenerator
    {
        private AdtGekidDbContext _context { get; }

        private readonly Random _random = new Random();

        public Configuration Config { get; set; }

        public Generator(AdtGekidDbContext context)
        {
            _context = context;
            Config = new Configuration();
        }


        public int CreateRandomValue(int min, int max) => _random.Next(min, max + 1);
        public int CreateRandomValue(int delta) => _random.Next(delta * -1, delta);

        public double CreateNormalValueUponMean(double mean, double stdDev)
        {
            Normal normalDistr = new Normal(mean, stdDev, _random);
            return normalDistr.Sample();
        }

        public int CreateNormalValueUponRange(int min, int max)
        {
            double mean = max / 2;    // medium value
            double stdDev = mean / 3;  // assume 3sigma borders (99,7%)
            int fetchedId = (int)CreateNormalValueUponMean(mean, stdDev);
            if (fetchedId < min)
                fetchedId = min;
            if (fetchedId > max)
                fetchedId = max;
            return fetchedId;
        }

        private DateTime createRandomDate(int deltaDays, DateTime baseDate) => baseDate.AddDays(CreateRandomValue(deltaDays));

        /// <summary>
        /// HACK private vs public
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T FetchRandomEnumItem<T>(double missingProb = 0) where T : Enum
        {
            var list = fetchAllEnumItems<T>();
            var itemNone = fetchNoneEnumItem(list);
            // handle missingProb
            if (_random.NextDouble() < missingProb)
                return fetchNoneEnumItem(list);     // warning: if no item "none" is present, this will return enum[0]

            if (itemNone?.ToString() == "None")
                list.Remove(itemNone);
            return list[_random.Next(list.Count)];
        }

        private IList<T> fetchAllEnumItems<T>()
        {
            var list = Enum.GetValues(typeof(T)).OfType<T>().ToList();          // same as: (array as T[]).ToList()
            return list;
        }


        /// <summary>
        /// Fetches the enum item "none".
        /// </summary>
        /// <typeparam name="T">enum</typeparam>
        /// <returns>"none" item or default (item at index 0)</returns>
        private T fetchNoneEnumItem<T>(IList<T> list) where T : Enum => list
                .Where(i => i.ToString() == "None")     // ToStringXmlEnum() would exclude "none", do not use
                .FirstOrDefault();                                         


        /// <summary>
        /// Fetches a Dimension item following normal distribuion
        /// If no subset is provided, whole list will be taken 
        /// </summary>
        /// <typeparam name="T">dimension</typeparam>
        /// <param name="subset">subset as list or null</param>
        /// <returns>dimension item</returns>
        public T FetchNormalDimensionItem<T>(List<T> subset = null) where T : DimensionBase
        {
            // HACK this is inconsistent w/ Random
            if (subset == null)
                subset = _context.GetAll<T>().ToList();
            var count = subset.Count();
            // have index range (0, n-1) instead of id (1,n)
            var rng = CreateNormalValueUponRange(0, count - 1);
            return _context.GetByIndex(rng, subset);
        }

        public T FetchRandomDimensionItem<T>(List<T> subset = null, double missingProb = 0) where T : DimensionBase
        {
            // handle subset
            if (subset == null)
                subset = _context.GetAll<T>().ToList();
            // handle missingProb
            if (_random.NextDouble() < missingProb)
                return null;

            var count = subset.Count();
            var rng = CreateRandomValue(0, count - 1);
            return _context.GetByIndex(rng, subset);
        }


        /* specific*/

        public Icd FetchNormalDimensionItem_Icd(string chapter)
        {
            if (_random.NextDouble() < Config.Icd_ProbMissing)
                return null;
            if (chapter == "")  
                return FetchNormalDimensionItem<Icd>();
            var subset = _context.GetIcdSubsetByChapter(chapter);
            return FetchNormalDimensionItem<Icd>(subset);
        }

        public int CreateFixedValuePatientCount() => Config.Patient_Count;

        public DateTime CreateRandomDate_Meldedatum() => createRandomDate(10 * 365, Config.Meldedatum_BaseDate);
        public DateTime CreateRandomDate_Geburtsdatum() => createRandomDate(40 * 365, new DateTime(1970, 01, 01));

        public int GetDaysToPublishDate(DateTime start) => (Config.PublishDate - start).Days;
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
