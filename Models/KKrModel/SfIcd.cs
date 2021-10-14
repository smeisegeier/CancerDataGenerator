using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfIcd
    {
        public SfIcd()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string IcdId { get; set; }
        public string IcdChapter { get; set; }
        public string IcdGroup { get; set; }
        public string IcdThreeDigits { get; set; }
        public string IcdFourDigits { get; set; }
        public string IcdFiveDigits { get; set; }
        public string IcdDescription { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
