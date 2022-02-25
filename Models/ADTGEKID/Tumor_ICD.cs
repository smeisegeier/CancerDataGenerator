using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Tumor_ICD
    {
        [RegularExpression(@"[CD]\d\d(\.\d(\d) ?) ?|M72.4")]
        public string Code { get; set; }

        public ICD_Version_Typ Version { get; set; }

    }
}
