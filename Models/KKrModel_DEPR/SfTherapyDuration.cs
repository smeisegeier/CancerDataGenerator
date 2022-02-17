using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfTherapyDuration
    {
        public SfTherapyDuration()
        {
            FactCaseRadiotherapies = new HashSet<FactCaseRadiotherapy>();
            FactCaseSystemicTherapies = new HashSet<FactCaseSystemicTherapy>();
        }

        public int TherapyDurationId { get; set; }
        public string TherapyDurationShortname { get; set; }
        public string TherapyDurationLongnameEnglish { get; set; }
        public string TherapyDurationLongnameGerman { get; set; }

        public virtual ICollection<FactCaseRadiotherapy> FactCaseRadiotherapies { get; set; }
        public virtual ICollection<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
    }
}
