using System;
using System.Collections.Generic;

#nullable disable

namespace Rki.CancerDataGenerator.Models.KKrModel
{
    public partial class SfUicc
    {
        public SfUicc()
        {
            FactCases = new HashSet<FactCase>();
        }

        public string UiccId { get; set; }
        public string UiccName { get; set; }
        public string UiccGroup { get; set; }
        public string UiccDescriptionEnglish { get; set; }
        public string UiccDescriptionGerman { get; set; }

        public virtual ICollection<FactCase> FactCases { get; set; }
    }
}
