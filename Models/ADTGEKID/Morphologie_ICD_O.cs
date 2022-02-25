using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Morphologie_ICD_O
    {
        [RegularExpression(@"\d\d\d\d/\d")]
        public string Code { get; set; }

        public Morphologie_ICD_O_Version_Typ Version { get; set; }

    }
}
