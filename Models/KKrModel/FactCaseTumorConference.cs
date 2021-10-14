using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class FactCaseTumorConference
    {
        public int CaseId { get; set; }
        public string TumorConferenceId { get; set; }
        public DateTime? Date { get; set; }

        public virtual FactCase Case { get; set; }
        public virtual SfTumorConference TumorConference { get; set; }
    }
}
