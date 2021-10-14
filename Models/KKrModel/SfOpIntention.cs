using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfOpIntention
    {
        public SfOpIntention()
        {
            FactCaseOperations = new HashSet<FactCaseOperation>();
        }

        public string OpIntentionId { get; set; }
        public string OpIntentionShortname { get; set; }
        public string OpIntentionLongnameEnglish { get; set; }
        public string OpIntentionLongnameGerman { get; set; }

        public virtual ICollection<FactCaseOperation> FactCaseOperations { get; set; }
    }
}
