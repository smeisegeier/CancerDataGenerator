using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfDistantMetastase
    {
        public SfDistantMetastase()
        {
            FactCaseDistantMetastases = new HashSet<FactCaseDistantMetastase>();
        }

        public string DistantMetastasesId { get; set; }
        public string DistantMetastasesShortname { get; set; }
        public string DistantMetastasesLongnameEnglish { get; set; }
        public string DistantMetastasesLongnameGerman { get; set; }

        public virtual ICollection<FactCaseDistantMetastase> FactCaseDistantMetastases { get; set; }
    }
}
