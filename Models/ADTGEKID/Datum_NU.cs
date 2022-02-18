using System;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    [Obsolete]
    public class Datum_NU
    {
        [System.Xml.Serialization.XmlElement("Datum", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("NU", typeof(Datum_NU_TypNU))]
        public object Item { get; set; }
    }
}