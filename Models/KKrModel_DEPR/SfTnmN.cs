using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfTnmN
    {
        public SfTnmN()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string TnmNId { get; set; }
        public string TnmNPrefix { get; set; }
        public string TnmNGroupShortname { get; set; }
        public string TnmNShortname { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
