using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfTumorStatus
    {
        public SfTumorStatus()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string TumorStatusId { get; set; }
        public string TumorStatusShortname { get; set; }
        public string TumorStatusLongnameEnglish { get; set; }
        public string TumorStatusLongnameGerman { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
