using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Histologie
    {

        [RegularExpression(@"\d\d\d\d/\d")]
        public string Morphologie_Code { get; set; }

        public Histologie_TypMorphologie_ICD_O_Version Morphologie_ICD_O_Version { get; set; }

        public Histologie_TypGrading Grading { get; set; }

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LK_untersucht { get; set; }

        [XmlElement(DataType = "nonNegativeInteger")]
        public string LK_befallen { get; set; }
    }
}