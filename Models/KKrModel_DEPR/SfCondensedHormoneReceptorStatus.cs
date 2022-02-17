using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfCondensedHormoneReceptorStatus
    {
        public SfCondensedHormoneReceptorStatus()
        {
            FactModuleBreastCancers = new HashSet<FactModuleBreastCancer>();
        }

        public string CondensedReceptorStatusId { get; set; }
        public string CondensedReceptorStatusShortname { get; set; }
        public string Her2Status { get; set; }
        public string EstrogenStatus { get; set; }
        public string ProgesteroneStatus { get; set; }
        public string CondensedReceptorStatusLongnameEnglish { get; set; }
        public string CondensedReceptorStatusLongnameGerman { get; set; }

        public virtual ICollection<FactModuleBreastCancer> FactModuleBreastCancers { get; set; }
    }
}
