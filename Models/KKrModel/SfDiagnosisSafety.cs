using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfDiagnosisSafety
    {
        public SfDiagnosisSafety()
        {
            FactCases = new HashSet<FactCase>();
        }

        public int DiagnosisSafetyId { get; set; }
        public string DiagnosisSafetyLongnameEnglish { get; set; }
        public string DiagnosisSafetyLongnameGerman { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
