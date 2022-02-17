using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfTherapyLine
    {
        public SfTherapyLine()
        {
            FactCaseOperations = new HashSet<FactCaseOperation>();
            FactCaseRadiotherapies = new HashSet<FactCaseRadiotherapy>();
            FactCaseSystemicTherapies = new HashSet<FactCaseSystemicTherapy>();
        }

        public int TherapyLineId { get; set; }
        public string TherapyLineShortname { get; set; }
        public string TherapyLineLongnameEnglish { get; set; }
        public string TherapyLineLongnameGerman { get; set; }

        public virtual ICollection<FactCaseOperation> FactCaseOperations { get; set; }
        public virtual ICollection<FactCaseRadiotherapy> FactCaseRadiotherapies { get; set; }
        public virtual ICollection<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
    }
}
