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

        /// <summary>
        /// HACK private vs public
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T getRandomEnumItem<T>() where T : Enum
        {
            //var array = Enum.GetValues(typeof(T));
            //List<T> list = (array as T[]).ToList();

            var list = Enum.GetValues(typeof(T)).OfType<T>().ToList();          // same as: (array as T[]).ToList()
            var itemRemoving = list
                .Where(i => i.ToString() == "None")
                .FirstOrDefault();                                              // ToStringXmlEnum() would exclude "none", do not use
            // TODO null vs default
            if (itemRemoving != null)
                list.Remove(itemRemoving);
            return list[_random.Next(list.Count)];
        }

        private T getNormalDimensionItem<T>(List<T> subset = null) where T : DimensionBase
        {
            if (subset == null)
                subset = _context.GetAll<T>().ToList();
            int count = subset.Count();
            // have index range (0, n-1) instead of id (1,n)
            var rng = CreateNormalValue(0, count - 1);
            return _context.GetByIndex(rng, subset);
        }


        public T FetchRandomDimensionItem<T>() where T : DimensionBase
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
            return getRandomEnumItem<ICD_Version_Typ>();
        }

        public PatientMeldungDiagnoseDiagnosesicherung FetchRandomEnumItem_Dsich()
        {
            if (_random.NextDouble() < _config.Dsich_ProbMissing)
                return PatientMeldungDiagnoseDiagnosesicherung.None;
            return getRandomEnumItem<PatientMeldungDiagnoseDiagnosesicherung>();
        }

        public PatientMeldungMeldebegruendung FetchRandomEnumItem_Meldebegruendung()
        {
            if (_random.NextDouble() < 0)
                return PatientMeldungMeldebegruendung.None;
            return getRandomEnumItem<PatientMeldungMeldebegruendung>();
        }

        public PatientMeldungMeldeanlass FetchRandomEnumItem_Meldeanlass()
        {
            if (_random.NextDouble() < 0)
                return PatientMeldungMeldeanlass.None;
            return getRandomEnumItem<PatientMeldungMeldeanlass>();
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
        // TODO make random calculations respect LINQ subsets 

    }
}
