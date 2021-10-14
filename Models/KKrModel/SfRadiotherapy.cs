using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfRadiotherapy
    {
        public SfRadiotherapy()
        {
            FactCaseRadiotherapies = new HashSet<FactCaseRadiotherapy>();
        }

        public string RadiotherapyId { get; set; }
        public string RadiotherapyTargetAreaRough { get; set; }
        public string RadiotherapyTargetAreaFine { get; set; }
        public string RadiotherapyTargetAreaFinest { get; set; }
        public bool? RadiotherapyLymphNodes { get; set; }
        public string RadiotherapyDescriptionEnglish { get; set; }
        public string RadiotherapyDescriptionGerman { get; set; }

        public virtual ICollection<FactCaseRadiotherapy> FactCaseRadiotherapies { get; set; }
    }
}
