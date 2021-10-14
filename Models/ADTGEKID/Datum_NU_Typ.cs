namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Datum_NU_Typ
    {
        [System.Xml.Serialization.XmlElementAttribute("Datum", typeof(System.DateTime), DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("NU", typeof(Datum_NU_TypNU))]
        public object Item { get; set; }
    }
}