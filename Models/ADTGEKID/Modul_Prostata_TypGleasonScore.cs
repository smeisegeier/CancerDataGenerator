namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Modul_Prostata_TypGleasonScore
    {
        public Modul_Prostata_TypGleasonScoreGleasonGradPrimaer GleasonGradPrimaer { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GleasonGradPrimaerSpecified { get; set; }

        public Modul_Prostata_TypGleasonScoreGleasonGradSekundaer GleasonGradSekundaer { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GleasonGradSekundaerSpecified { get; set; }

        public Modul_Prostata_TypGleasonScoreGleasonScoreErgebnis GleasonScoreErgebnis { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GleasonScoreErgebnisSpecified { get; set; }
    }
}