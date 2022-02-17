using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfTherapyRelation
    {
        public SfTherapyRelation()
        {
            FactCaseRadiotherapies = new HashSet<FactCaseRadiotherapy>();
            FactCaseSystemicTherapies = new HashSet<FactCaseSystemicTherapy>();
        }

        public string TherapyRelationId { get; set; }
        public string TherapyRelationShortname { get; set; }
        public string TherapyRelationLongnameEnglish { get; set; }
        public string TherapyRelationLongnameGerman { get; set; }
        public int TherapyRelationOrdinal { get; set; }

        public virtual ICollection<FactCaseRadiotherapy> FactCaseRadiotherapies { get; set; }
        public virtual ICollection<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
    }
}
