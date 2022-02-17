using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class FactCaseSystemicTherapy
    {
        public FactCaseSystemicTherapy()
        {
            FactSystemicTherapySubstances = new HashSet<FactSystemicTherapySubstance>();
        }

        public int SystemicTherapyId { get; set; }
        public int? CaseId { get; set; }
        public string SystemicTherapy { get; set; }
        public string TherapyRelation { get; set; }
        public string TherapyIntention { get; set; }
        public string TherapyProtocol { get; set; }
        public DateTime? TherapyBegin { get; set; }
        public DateTime? TherapyEnd { get; set; }
        public int? TherapyDuration { get; set; }
        public string TherapyTimeRelation { get; set; }
        public string TherapyStopReason { get; set; }
        public int CareProvider { get; set; }
        public int? TherapyLine { get; set; }
        public string Ops { get; set; }

        public virtual SfCareProvider CareProviderNavigation { get; set; }
        public virtual FactCase Case { get; set; }
        public virtual SfOp OpsNavigation { get; set; }
        public virtual SfSystemicTherapy SystemicTherapyNavigation { get; set; }
        public virtual SfTherapyDuration TherapyDurationNavigation { get; set; }
        public virtual SfTherapyIntention TherapyIntentionNavigation { get; set; }
        public virtual SfTherapyLine TherapyLineNavigation { get; set; }
        public virtual SfProtocol TherapyProtocolNavigation { get; set; }
        public virtual SfTherapyRelation TherapyRelationNavigation { get; set; }
        public virtual SfTherapyStop TherapyStopReasonNavigation { get; set; }
        public virtual SfTherapyTimeRelation TherapyTimeRelationNavigation { get; set; }
        public virtual ICollection<FactSystemicTherapySubstance> FactSystemicTherapySubstances { get; set; }
    }
}
