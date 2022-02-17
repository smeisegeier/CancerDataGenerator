using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfEcog
    {
        public SfEcog()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string EcogId { get; set; }
        public string EcogShortname { get; set; }
        public string EcogLongnameEnglish { get; set; }
        public string EcogLongnameGerman { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
