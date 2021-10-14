using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfSide
    {
        public SfSide()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string SideId { get; set; }
        public string SideShortname { get; set; }
        public string SideLongnameEnglish { get; set; }
        public string SideLongnameGerman { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
