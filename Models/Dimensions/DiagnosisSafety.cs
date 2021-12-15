using Newtonsoft.Json;

namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public class DiagnosisSafety :DimensionBase
    {
        public int diagnosis_safety_id { get; set; }
        public string diagnosis_safety_longname_english { get; set; }
        public string diagnosis_safety_longname_german { get; set; }
    }
}
