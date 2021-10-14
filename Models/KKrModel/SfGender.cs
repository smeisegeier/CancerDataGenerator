using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfGender
    {
        public SfGender()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string GenderId { get; set; }
        public string GenderShortname { get; set; }
        public string GenderLongnameEnglish { get; set; }
        public string GenderLongnameGerman { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
