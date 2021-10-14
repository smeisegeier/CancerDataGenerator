using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfTnmT
    {
        public SfTnmT()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string TnmTId { get; set; }
        public string TnmTPrefix { get; set; }
        public string TnmTGroupShortname { get; set; }
        public string TnmTShortname { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
