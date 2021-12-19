namespace Rki.CancerDataGenerator.BLL
{
    public class Configuration
    {
        public int PatientCount { get; set; } = 5;
        public int MeanAgeDiagnosis { get; set; } = 50; 
        public double ProbMissingText { get; set; } = 0.9;
        public double ProbMissingIcdVersion { get; set; } = 0.1;
        public double ProbMissingIcd { get; set; } = 0;
    }
}
