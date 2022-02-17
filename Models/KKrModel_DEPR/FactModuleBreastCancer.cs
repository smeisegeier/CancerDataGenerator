using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class FactModuleBreastCancer
    {
        public int CaseId { get; set; }
        public string Her2neuStatus { get; set; }
        public string EstrogenStatus { get; set; }
        public string ProgesteroneStatus { get; set; }
        public string CondensedReceptorStatus { get; set; }

        public virtual FactCase Case { get; set; }
        public virtual SfCondensedHormoneReceptorStatus CondensedReceptorStatusNavigation { get; set; }
        public virtual SfHormoneReceptorStatus EstrogenStatusNavigation { get; set; }
        public virtual SfHormoneReceptorStatus Her2neuStatusNavigation { get; set; }
        public virtual SfHormoneReceptorStatus ProgesteroneStatusNavigation { get; set; }
    }
}
