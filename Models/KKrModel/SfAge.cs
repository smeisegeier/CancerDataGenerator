using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfAge
    {
        public SfAge()
        {
            FactCaseDeathAgeNavigations = new HashSet<FactCase>();
            FactCaseDiagnosisAgeNavigations = new HashSet<FactCase>();
        }

        public int AgeId { get; set; }

        public virtual ICollection<FactCase> FactCaseDeathAgeNavigations { get; set; }
        public virtual ICollection<FactCase> FactCaseDiagnosisAgeNavigations { get; set; }
    }
}
