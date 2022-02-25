using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Topographie_ICD
    {
        [RegularExpression(@"C\d\d\.\d(\d)?")]
        public string Code { get; set; }

        public Topographie_ICD_O_Version_Typ Version { get; set; }
    }
}
