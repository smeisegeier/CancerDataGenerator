using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfTumorStatusDistantMetastase
    {
        public SfTumorStatusDistantMetastase()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string TumorStatusDistantMetastasesId { get; set; }
        public string TumorStatusDistantMetastasesShortname { get; set; }
        public string TumorStatusDistantMetastasesLongnameEnglish { get; set; }
        public string TumorStatusDistantMetastasesLongnameGerman { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
