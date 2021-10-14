using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfLocation
    {
        public SfLocation()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string LocationId { get; set; }
        public string LocationState { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
