using System;

namespace Rki.CancerDataGenerator.BLL
{
    public class Configuration
    {
        public int Patient_Count { get; set; } = 2;
        public int Diagnose_MeanAge { get; set; } = 50; 
        public double Text_ProbMissing { get; set; } = 0.9;
        public double IcdVersion_ProbMissing { get; set; } = 0.1;
        public double Icd_ProbMissing { get; set; } = 0;

        public DateTime Meldedatum_BaseDate { get; set; } = new DateTime(2000, 01, 01);
        public int Meldedatum_DaysRange { get; set; } = 10 * 365; 
    }
}
