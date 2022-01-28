using System;

namespace Rki.CancerDataGenerator.BLL
{
    public class Configuration
    {
        public DateTime PublishDate => new DateTime(2020, 01, 01);
        
        /// <summary>How many patients</summary>
        /// <example>2</example>
        public int Patient_Count { get; set; } = 1;
        public int Patient_MeanAge { get; set; } = 50; 
        public double Text_ProbMissing { get; set; } = 0.9;
        public double IcdVersion_ProbMissing { get; set; } = 0.1;
        public double Icd_ProbMissing { get; set; } = 0.1;

        public double Dsich_ProbMissing { get; set; } = 0.0;


        public DateTime Meldedatum_BaseDate { get; set; } = new DateTime(2010, 01, 01);
        public int Meldedatum_DaysRange { get; set; } = 10 * 365; 
    }
}
