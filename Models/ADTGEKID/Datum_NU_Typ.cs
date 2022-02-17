namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Datum_NU_Typ
    {
        [System.Xml.Serialization.XmlElement("Datum", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("NU", typeof(Datum_NU_TypNU))]
        public object Item { get; set; }
    }
}