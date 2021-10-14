using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class FactCaseOperation
    {
        public FactCaseOperation()
        {
            FactOperationAdditionalOps = new HashSet<FactOperationAdditionalOp>();
        }

        public int OperationId { get; set; }
        public int? CaseId { get; set; }
        public string Ops { get; set; }
        public string OpIntention { get; set; }
        public DateTime? OpDate { get; set; }
        public string ResidualStatus { get; set; }
        public int CareProvider { get; set; }
        public int TherapyLine { get; set; }

        public virtual SfCareProvider CareProviderNavigation { get; set; }
        public virtual FactCase Case { get; set; }
        public virtual SfOpIntention OpIntentionNavigation { get; set; }
        public virtual SfOp OpsNavigation { get; set; }
        public virtual SfResidualStatus ResidualStatusNavigation { get; set; }
        public virtual SfTherapyLine TherapyLineNavigation { get; set; }
        public virtual ICollection<FactOperationAdditionalOp> FactOperationAdditionalOps { get; set; }
    }
}
