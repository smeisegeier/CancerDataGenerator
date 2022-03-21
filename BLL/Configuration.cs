using System;

namespace Rki.CancerDataGenerator.BLL
{
    /// <summary>
    /// May only reside within a Generator
    /// </summary>
    public class Configuration
    {
        public DateTime PublishDate => new DateTime(2020, 01, 01);
        
        /// <summary>How many patients</summary>
        /// <example>3</example>
        public int Patient_Count { get; set; } = 3;

        /// <summary>Mean age</summary>
        /// <example>50</example>
        public int Patient_MeanAge { get; set; } = 50;

        /// <summary>Prob missing</summary>
        /// <example>0.0</example>
        public double Text_ProbMissing { get; set; } = 0.0;

        /// <summary>Prob missing IcdVersion</summary>
        /// <example>0.0</example>
        public double IcdVersion_ProbMissing { get; set; } = 0.0;

        /// <summary>Prob missing Icd</summary>
        /// <example>0.0</example>
        public double Icd_ProbMissing { get; set; } = 0.0;

        /// <summary>Prob missing DSICH</summary>
        /// <example>0.0</example>
        public double Dsich_ProbMissing { get; set; } = 0.0;

        /// <summary>Meldedatum</summary>
        /// <example>2010-01-01T15:52:45.339Z</example>
        public DateTime Meldedatum_BaseDate { get; set; } = new DateTime(2010, 01, 01);

        /// <summary>DayRange</summary>
        /// <example>3650</example>
        public int Meldedatum_DaysRange { get; set; } = 10 * 365;

        public int GetTimeToPublishDateInDays(DateTime start) => (PublishDate - start).Days;
        public int GetTimeToPublishDateInYears(DateTime start) => GetTimeToPublishDateInDays(start) / 365;
    }
}
