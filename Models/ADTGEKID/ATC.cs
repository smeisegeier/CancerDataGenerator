using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class ATC
    {
        [RegularExpression(@"[A-Z]\d\d[A-Z][A-Z]\d\d")]
        public string Code { get; set; }

        [RegularExpression(@"200[4-9]|20[12]\d")]
        public string Version { get; set; }

    }
}