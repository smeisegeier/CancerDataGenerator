using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class FactCaseRadiotherapy
    {
        public int RadiotherapyId { get; set; }
        public int? CaseId { get; set; }
        public string Radiotherapy { get; set; }
        public string TherapyRelation { get; set; }
        public string TherapyIntention { get; set; }
        public DateTime? TherapyBegin { get; set; }
        public DateTime? TherapyEnd { get; set; }
        public int? TherapyDuration { get; set; }
        public string TherapyTimeRelation { get; set; }
        public int CareProvider { get; set; }
        public int TherapyLine { get; set; }
        public string Ops { get; set; }

        public virtual SfCareProvider CareProviderNavigation { get; set; }
        public virtual FactCase Case { get; set; }
        public virtual SfOp OpsNavigation { get; set; }
        public virtual SfRadiotherapy RadiotherapyNavigation { get; set; }
        public virtual SfTherapyDuration TherapyDurationNavigation { get; set; }
        public virtual SfTherapyIntention TherapyIntentionNavigation { get; set; }
        public virtual SfTherapyLine TherapyLineNavigation { get; set; }
        public virtual SfTherapyRelation TherapyRelationNavigation { get; set; }
        public virtual SfTherapyTimeRelation TherapyTimeRelationNavigation { get; set; }
    }
}
