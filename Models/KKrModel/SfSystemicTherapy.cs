using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfSystemicTherapy
    {
        public SfSystemicTherapy()
        {
            FactCaseSystemicTherapies = new HashSet<FactCaseSystemicTherapy>();
        }

        public string SystemicTherapyId { get; set; }
        public string SystemicTherapyShortname { get; set; }
        public string SystemicTherapyLongnameEnglish { get; set; }
        public string SystemicTherapyLongnameGerman { get; set; }

        public virtual ICollection<FactCaseSystemicTherapy> FactCaseSystemicTherapies { get; set; }
    }
}
