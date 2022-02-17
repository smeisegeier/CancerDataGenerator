using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfProtocol
    {
        public SfProtocol()
        {
            FactCaseSystemicTherapies = new HashSet<FactCaseSystemicTherapy>();
            FactProtocolSubstances = new HashSet<FactProtocolSubstance>();
        }

        public string ProtocolId { get; set; }
        public string ProtocolShortname { get; set; }
        public string ProtocolLongnameEnglish { get; set; }
        public string ProtocolLongnameGerman { get; set; }

        public virtual ICollection<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
        public virtual ICollection<FactProtocolSubstance> FactProtocolSubstances { get; set; }
    }
}
