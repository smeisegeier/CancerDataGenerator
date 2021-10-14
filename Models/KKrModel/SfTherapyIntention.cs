using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfTherapyIntention
    {
        public SfTherapyIntention()
        {
            FactCaseRadiotherapies = new HashSet<FactCaseRadiotherapy>();
            FactCaseSystemicTherapies = new HashSet<FactCaseSystemicTherapy>();
        }

        public string TherapyIntentionId { get; set; }
        public string TherapyIntentionShortname { get; set; }
        public string TherapyIntentionLongnameEnglish { get; set; }
        public string TherapyIntentionLongnameGerman { get; set; }

        public virtual ICollection<FactCaseRadiotherapy> FactCaseRadiotherapies { get; set; }
        public virtual ICollection<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
    }
}
