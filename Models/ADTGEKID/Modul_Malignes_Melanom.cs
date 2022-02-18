using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Modul_Malignes_Melanom
    {
        // TODO 0.1 - 99
        [Range(1,99)]
        public decimal Tumordicke { get; set; }

        [Range(1, 10000)]
        [System.Xml.Serialization.XmlElement(DataType = "integer")]
        public string LDH { get; set; }

    }
}