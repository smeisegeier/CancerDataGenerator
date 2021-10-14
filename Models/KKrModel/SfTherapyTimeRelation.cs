using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfTherapyTimeRelation
    {
        public SfTherapyTimeRelation()
        {
            FactCaseRadiotherapies = new HashSet<FactCaseRadiotherapy>();
            FactCaseSystemicTherapies = new HashSet<FactCaseSystemicTherapy>();
        }

        public string TherapyTimeRelationId { get; set; }
        public string TherapyTimeRelationShortname { get; set; }
        public string TherapyTimeRelationLongnameEnglish { get; set; }
        public string TherapyTimeRelationLongnameGerman { get; set; }
        public int TherapyTimeRelationOrdinal { get; set; }

        public virtual ICollection<FactCaseRadiotherapy> FactCaseRadiotherapies { get; set; }
        public virtual ICollection<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
    }
}
