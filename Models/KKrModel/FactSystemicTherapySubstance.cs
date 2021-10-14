using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class FactSystemicTherapySubstance
    {
        public int SystemicTherapyId { get; set; }
        public string SubstanceId { get; set; }

        public virtual SfSubstance Substance { get; set; }
        public virtual FactCaseSystemicTherapy SystemicTherapy { get; set; }
    }
}
