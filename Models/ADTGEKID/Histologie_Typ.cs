using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Histologie_Typ
    {
        public string Tumor_Histologiedatum { get; set; }

        
        public string Histologie_EinsendeNr { get; set; }

        
        [RegularExpression(@"\d\d\d\d/\d")]
        public string Morphologie_Code { get; set; }

        
        public Histologie_TypMorphologie_ICD_O_Version Morphologie_ICD_O_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Morphologie_ICD_O_VersionSpecified { get; set; }

        
        public string Morphologie_Freitext { get; set; }

        
        public Histologie_TypGrading Grading { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GradingSpecified { get; set; }

        
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string LK_untersucht { get; set; }

        
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string LK_befallen { get; set; }

        
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string Sentinel_LK_untersucht { get; set; }

        
        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string Sentinel_LK_befallen { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Histologie_ID { get; set; }


        public static Histologie_Typ GetItem()
        {
            var a = new Histologie_Typ();
            a.Grading = Histologie_TypGrading.B;
            a.GradingSpecified = true;
            a.Histologie_EinsendeNr = "1e";
            a.Histologie_ID = "1";
            a.LK_befallen = "xde";
            a.LK_untersucht = "ka";
            a.Morphologie_Code = "MORPH";
            return a;
        }
    }
}