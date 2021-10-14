namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Modul_Prostata_Typ
    {
        public Modul_Prostata_TypGleasonScore GleasonScore { get; set; }
        public Modul_Prostata_TypAnlassGleasonScore AnlassGleasonScore { get; set; }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnlassGleasonScoreSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DatumStanzen { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatumStanzenSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string AnzahlStanzen { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
        public string AnzahlPosStanzen { get; set; }

        public Modul_Prostata_TypCaBefallStanze CaBefallStanze { get; set; }

        public decimal PSA { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PSASpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime DatumPSA { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DatumPSASpecified { get; set; }

        public JNU_Typ KomplPostOP_ClavienDindo { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KomplPostOP_ClavienDindoSpecified { get; set; }
    }
}