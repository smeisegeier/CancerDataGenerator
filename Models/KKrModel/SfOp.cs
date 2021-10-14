using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfOp
    {
        public SfOp()
        {
            FactCaseOperations = new HashSet<FactCaseOperation>();
            FactCaseRadiotherapies = new HashSet<FactCaseRadiotherapy>();
            FactCaseSystemicTherapies = new HashSet<FactCaseSystemicTherapy>();
            FactOperationAdditionalOps = new HashSet<FactOperationAdditionalOp>();
        }

        public string OpsId { get; set; }
        public string OpsChapter { get; set; }
        public string OpsGroup { get; set; }
        public string OpsThreeDigits { get; set; }
        public string OpsFourDigits { get; set; }
        public string OpsFiveDigits { get; set; }
        public string OpsSixDigits { get; set; }
        public string OpsDescription { get; set; }
        public bool? OpsAdditionalCode { get; set; }
        public bool? OpsUseOnceCode { get; set; }
        public bool? OpsRequiresSide { get; set; }

        public virtual ICollection<FactCaseOperation> FactCaseOperations { get; set; }
        public virtual ICollection<FactCaseRadiotherapy> FactCaseRadiotherapies { get; set; }
        public virtual ICollection<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
        public virtual ICollection<FactOperationAdditionalOp> FactOperationAdditionalOps { get; set; }
    }
}
