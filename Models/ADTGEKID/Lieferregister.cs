using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Lieferregister
    {
       

        [XmlAttribute]
        public ISO3199_2 Register_ID { get; set; }


        [XmlAttribute]
        public string Software_ID { get; set; }


        [XmlAttribute]
        public string Installations_ID { get; set; }
    }
}