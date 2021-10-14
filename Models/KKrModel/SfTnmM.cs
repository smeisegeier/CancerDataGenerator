using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfTnmM
    {
        public SfTnmM()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string TnmMId { get; set; }
        public string TnmMPrefix { get; set; }
        public string TnmMGroupShortname { get; set; }
        public string TnmMShortname { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
