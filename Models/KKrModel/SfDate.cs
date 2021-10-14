using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfDate
    {
        public SfDate()
        {
            FactCases = new HashSet<FactCase>();
            FactSurvivalAnalysisSurvivalAnalysisEndDateNavigations = new HashSet<FactSurvivalAnalysis>();
            FactSurvivalAnalysisSurvivalAnalysisStartDateNavigations = new HashSet<FactSurvivalAnalysis>();
        }

        public string DateId { get; set; }
        public int? DateYear { get; set; }
        public string DateYearName { get; set; }
        public int? DateSemester { get; set; }
        public string DateSemesterName { get; set; }
        public int? DateQuarter { get; set; }
        public string DateQuarterName { get; set; }
        public int? DateMonth { get; set; }
        public string DateMonthName { get; set; }
        public int? DateDay { get; set; }
        public string DateDayName { get; set; }
        public string DateNameEnglish { get; set; }
        public string DateNameGerman { get; set; }
        public DateTime DateMean { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
        public virtual ICollection<FactSurvivalAnalysis> FactSurvivalAnalysisSurvivalAnalysisEndDateNavigations { get; set; }
        public virtual ICollection<FactSurvivalAnalysis> FactSurvivalAnalysisSurvivalAnalysisStartDateNavigations { get; set; }
    }
}
