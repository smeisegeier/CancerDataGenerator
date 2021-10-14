using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfSurvivalAnalysisType
    {
        public SfSurvivalAnalysisType()
        {
            FactSurvivalAnalyses = new HashSet<FactSurvivalAnalysis>();
        }

        public string SurvivalAnalysisTypeId { get; set; }
        public string SurvivalAnalysisTypeShortname { get; set; }
        public string SurvivalAnalysisTypeLongnameEnglish { get; set; }
        public string SurvivalAnalysisTypeLongnameGerman { get; set; }

        public virtual ICollection<FactSurvivalAnalysis> FactSurvivalAnalyses { get; set; }
    }
}
