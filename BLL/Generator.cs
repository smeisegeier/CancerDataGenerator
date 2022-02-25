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
    /// Requires context
    /// Glossary:
    /// - get -> 
    /// - fetch -> fetch an existing entry following random spread
    /// - create -> create a random entry from scratch
    /// </summary>
    public class Generator : DimensionBase      //, IGenerator
    {
        private AdtGekidDbContext _context { get; }

        private Random _random { get;}

        public Configuration Configuration { get; set; }

        public Generator(AdtGekidDbContext context)
        {
            _context = context;
            _random = new Random();
            Configuration = new Configuration();
        }

        #region private area
        private DateTime createRandomDate(int deltaDays, DateTime baseDate) => baseDate.AddDays(CreateRandomValueInt(deltaDays));

        /// <summary>
        /// get all enums
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private IList<T> fetchAllEnumItems<T>() where T : Enum
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


        #endregion

        #region generics area
        public int CreateRandomValueInt(int min, int max) => _random.Next(min, max + 1);
        public int CreateRandomValueInt(int delta) => _random.Next(delta * -1, delta);
        public double CreateRandomValueDouble(double min, double max, int fractionDigits = 1) 
            => Math.Round(min + (_random.NextDouble() * (max - min)), 1);
        public bool CreateRandomBool() 
        {
            var rng = _random.Next(1,100);
            if (rng <= 50)
                return false;
            return true;
        }


        public DateTime CreateRandomDate_Meldedatum() => createRandomDate(10 * 365, Configuration.Meldedatum_BaseDate);
        public DateTime CreateRandomDate_Geburtsdatum() => createRandomDate(40 * 365, new DateTime(1970, 01, 01));

        public int GetMeldungCountPerAge(int age)
        {
            if (age < 30)
                return 1;
            if (age < 50)
                return 2;
            return 3;
        }


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



        /// <summary>
        /// get random enum
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

        /// <summary>
        /// Fetches RAW dimension item, no missing values considered.
        /// Based off of index numbers, not database id.
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="subset">subset of data</param>
        /// <param name="missingProb">probability for missing</param>
        /// <returns>dimension item</returns>
        public T FetchRandomDimensionItem<T>(List<T> subset = null, double missingProb = 0) where T : DimensionBase
        {
            // handle subset
            if (subset == null)
                subset = _context.GetAll<T>().ToList();
            // handle missingProb
            if (_random.NextDouble() < missingProb)
                return null;

            var count = subset.Count();
            var rng = CreateRandomValueInt(0, count - 1);
            return _context.GetByIndex(rng, subset);
        }

        #endregion


        #region specifics area
        public string CreateRandomValue_Inzidenzort() => CreateNormalValueUponRange(0, 99999).ToString("00000");


        /// <summary>
        /// Fetch ICD code -> can be null
        /// </summary>
        /// <param name="chapter">optional icd chapter</param>
        /// <returns>ICD code or null</returns>
        public Icd FetchNormalDimensionItem_Icd(string chapter)
        {
            if (_random.NextDouble() < Configuration.Icd_ProbMissing)
                return null;
            if (chapter == "")  
                return FetchNormalDimensionItem<Icd>();
            // filter out ranges
            var subset = _context.GetIcdSubsetByChapter(chapter).Where(x=> x.icd_three_digits.Length == 3).ToList();
            return FetchNormalDimensionItem<Icd>(subset);
        }

        public string FetchNormalDimensionItem_HistologySlashDignity()
        {
            // get all with a dot
            var subset = _context
                .GetAll<Histology>()
                .Where(x => x.histology_id.Contains("."))
                .ToList();
            return FetchNormalDimensionItem<Histology>(subset).histology_id.Replace(".","/");
        }


        public string FetchNormalDimensionItem_QuoteString(int maxLength)//(double probMissing = _config.Text_ProbMissing)
        {
            const string appendix = " ..";

            if (_random.NextDouble() < Configuration.Text_ProbMissing)
                return null;
            var result = FetchNormalDimensionItem<Quote>(null)?.quote;
            if (result.Length + appendix.Length <= maxLength)
                return result;
            return result.Substring(0, maxLength) + appendix;
        }

        #endregion
    }
}
