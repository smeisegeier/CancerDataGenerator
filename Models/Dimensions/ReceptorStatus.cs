namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public class ReceptorStatus : _DimensionBase
    {
        public string condensed_receptor_status_id { get; set; }
        public string condensed_receptor_status_shortname { get; set; }
        public string her_2_status { get; set; }
        public string estrogen_status { get; set; }
        public string progesterone_status { get; set; }
        public string condensed_receptor_status_longname_english { get; set; }
        public string condensed_receptor_status_longname_german { get; set; }
    }
}
