using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Morphologie
    {
        [RegularExpression(@"\d\d\d\d/\d")]
        public string Morphologie_Code { get; set; }

        public Morphologie_ICD_O_Version_Typ Morphologie_ICD_O_Version { get; set; }

    }
}
