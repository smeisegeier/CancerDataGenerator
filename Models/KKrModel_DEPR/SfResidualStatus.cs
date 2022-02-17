using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfResidualStatus
    {
        public SfResidualStatus()
        {
            FactCaseOperations = new HashSet<FactCaseOperation>();
        }

        public string ResidualStatusId { get; set; }
        public string ResidualStatusShortname { get; set; }
        public string ResidualStatusLongnameEnglish { get; set; }
        public string ResidualStatusLongnameGerman { get; set; }

        public virtual ICollection<FactCaseOperation> FactCaseOperations { get; set; }
    }
}
