using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfTherapyStop
    {
        public SfTherapyStop()
        {
            FactCaseSystemicTherapies = new HashSet<FactCaseSystemicTherapy>();
        }

        public string TherapyStopId { get; set; }
        public string TherapyStopShortname { get; set; }
        public string TherapyStopLongnameEnglish { get; set; }
        public string TherapyStopLongnameGerman { get; set; }

        public virtual ICollection<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
    }
}
