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


        public int createRandomValue(int min, int max) => _random.Next(min, max + 1);
        private int createRandomValue(int delta) => _random.Next(delta * -1, delta);


        public double CreateNormalValueUponMean(double mean, double stdDev)
        {
            Normal normalDistr = new Normal(mean, stdDev, _random);
            return normalDistr.Sample();
        }

        public int CreateNormalValueUponRange(int min, int max)
        {
            double mean = max / 2;    // medium value
            double stdDev = max / 6;  // assume 6sigma borders
            int fetchedId = (int)CreateNormalValueUponMean(mean, stdDev);
            if (fetchedId < min)
                fetchedId = min;
            if (fetchedId > max)
                fetchedId = max;
            return fetchedId;
        }

        private DateTime createRandomDate(int deltaDays, DateTime baseDate) => baseDate.AddDays(createRandomValue(deltaDays));

        /// <summary>
        /// HACK private vs public
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T FetchRandomEnumItem<T>() where T : Enum
        {
            var list = fetchAllEnumItems<T>();
            var itemRemoving = fetchNoneEnumItem(list);
            if (itemRemoving?.ToString() == "None")
                list.Remove(itemRemoving);
            return list[_random.Next(list.Count)];
        }

        private IList<T> fetchAllEnumItems<T>()
        {
            //var array = Enum.GetValues(typeof(T));
            //List<T> list = (array as T[]).ToList();

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
        private T getNormalDimensionItem<T>(List<T> subset = null) where T : DimensionBase
        {
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
            var rng = createRandomValue(0, count - 1);
            return _context.GetByIndex(rng, subset);
        }


        /* specific*/
        public Quote FetchRandomDimensionItem_Quote()
        {
            if (_random.NextDouble() < _config.Text_ProbMissing)
                return null;
            return FetchRandomDimensionItem<Quote>();
        }

        public Icd FetchNormalDimensionItem_Icd(string chapter = "")
        {
            if (_random.NextDouble() < _config.Icd_ProbMissing)
                return null;
            if (chapter == "")  
                return getNormalDimensionItem<Icd>();
            var subset = _context.GetIcdSubsetByChapter(chapter);
            return getNormalDimensionItem<Icd>(subset);
        }

        public ICD_Version_Typ FetchRandomEnumItem_IcdVersion()
        {
            if (_random.NextDouble() < _config.IcdVersion_ProbMissing)
                return ICD_Version_Typ.None;
            return FetchRandomEnumItem<ICD_Version_Typ>();
        }

        public PatientMeldungDiagnoseDiagnosesicherung FetchRandomEnumItem_Dsich()
        {
            if (_random.NextDouble() < _config.Dsich_ProbMissing)
                return PatientMeldungDiagnoseDiagnosesicherung.None;
            return FetchRandomEnumItem<PatientMeldungDiagnoseDiagnosesicherung>();
        }

        public PatientMeldungMeldebegruendung FetchRandomEnumItem_Meldebegruendung()
        {
            if (_random.NextDouble() < 0)
                return PatientMeldungMeldebegruendung.None;
            return FetchRandomEnumItem<PatientMeldungMeldebegruendung>();
        }

        public PatientMeldungMeldeanlass FetchRandomEnumItem_Meldeanlass()
        {
            if (_random.NextDouble() < 0)
                return PatientMeldungMeldeanlass.None;
            return FetchRandomEnumItem<PatientMeldungMeldeanlass>();
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
