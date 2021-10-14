using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfSubstance
    {
        public SfSubstance()
        {
            FactProtocolSubstances = new HashSet<FactProtocolSubstance>();
            FactSystemicTherapySubstances = new HashSet<FactSystemicTherapySubstance>();
        }

        public string SubstanceId { get; set; }
        public string AtcLevel1 { get; set; }
        public string AtcLevel1Label { get; set; }
        public string AtcLevel2 { get; set; }
        public string AtcLevel2Label { get; set; }
        public string AtcLevel3 { get; set; }
        public string AtcLevel3Label { get; set; }
        public string AtcLevel4 { get; set; }
        public string AtcLevel4Label { get; set; }
        public string AtcLevel5 { get; set; }
        public string AtcLevel5Label { get; set; }

        public virtual ICollection<FactProtocolSubstance> FactProtocolSubstances { get; set; }
        public virtual ICollection<FactSystemicTherapySubstance> FactSystemicTherapySubstances { get; set; }
    }
}
