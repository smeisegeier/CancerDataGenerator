namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public class Icd : DimensionBase
    {
        public string icd_id { get; set; }
        public string icd_chapter { get; set; }
        public string icd_group { get; set; }
        public string icd_three_digits { get; set; }
        public string icd_four_digits { get; set; }
        public string icd_five_digits { get; set; }
        public string icd_description { get; set; }
    }
}

