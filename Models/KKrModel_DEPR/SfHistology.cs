using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfHistology
    {
        public SfHistology()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string HistologyId { get; set; }
        public string DignityShortname { get; set; }
        public string DignityLongnameGerman { get; set; }
        public string HistologyShortname { get; set; }
        public string HistologyLongnameGerman { get; set; }
        public string GroupShortname { get; set; }
        public string GroupLongnameGerman { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
