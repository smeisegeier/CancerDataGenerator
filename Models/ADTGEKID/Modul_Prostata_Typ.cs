namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Modul_Prostata_Typ
    {
        public Modul_Prostata_TypGleasonScore GleasonScore { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DatumStanzen { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string AnzahlStanzen { get; set; }

        public decimal PSA { get; set; }
    }
}