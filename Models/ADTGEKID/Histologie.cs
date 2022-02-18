using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Histologie
    {
        [RegularExpression(@"\d\d\d\d/\d")]
        public string Morphologie_Code { get; set; }

        public Morphologie_ICD_O_Version_Typ Morphologie_ICD_O_Version { get; set; }

        public Grading_Typ Grading { get; set; }

        [Range(1,Int32.MaxValue)]
        public int LK_untersucht { get; set; }

        [Range(1, Int32.MaxValue)]
        public int LK_befallen { get; set; }
    }
}