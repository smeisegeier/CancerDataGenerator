using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfDiseaseProgression
    {
        public SfDiseaseProgression()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string DiseaseProgressionId { get; set; }
        public string DiseaseProgressionShortname { get; set; }
        public string DiseaseProgressionLongnameEnglish { get; set; }
        public string DiseaseProgressionLongnameGerman { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
