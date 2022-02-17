using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfGrading
    {
        public SfGrading()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string GradingId { get; set; }
        public string GradingShortname { get; set; }
        public string GradingLongnameEnglish { get; set; }
        public string GradingLongnameGerman { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
