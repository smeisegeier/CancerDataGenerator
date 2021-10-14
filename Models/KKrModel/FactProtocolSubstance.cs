using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class FactProtocolSubstance
    {
        public string ProtocolId { get; set; }
        public string SubstanceId { get; set; }

        public virtual SfProtocol Protocol { get; set; }
        public virtual SfSubstance Substance { get; set; }
    }
}
