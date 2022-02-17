using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel_DEPR
{
    public partial class SfTumorConference
    {
        public SfTumorConference()
        {
            FactCaseTumorConferences = new HashSet<FactCaseTumorConference>();
        }

        public string TumorConferenceId { get; set; }
        public string TumorConferenceShortname { get; set; }
        public string TumorConferenceLongnameEnglish { get; set; }
        public string TumorConferenceLongnameGerman { get; set; }

        public virtual ICollection<FactCaseTumorConference> FactCaseTumorConferences { get; set; }
    }
}
