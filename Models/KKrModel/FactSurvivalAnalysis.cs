using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class FactSurvivalAnalysis
    {
        public int SurvivalAnalysisCaseId { get; set; }
        public string SurvivalAnalysisStartDate { get; set; }
        public string SurvivalAnalysisEndDate { get; set; }
        public string SurvivalAnalysisType { get; set; }

        public virtual FactCase SurvivalAnalysisCase { get; set; }
        public virtual SfDate SurvivalAnalysisEndDateNavigation { get; set; }
        public virtual SfDate SurvivalAnalysisStartDateNavigation { get; set; }
        public virtual SfSurvivalAnalysisType SurvivalAnalysisTypeNavigation { get; set; }
    }
}
