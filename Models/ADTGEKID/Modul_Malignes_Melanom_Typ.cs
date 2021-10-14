namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Modul_Malignes_Melanom_Typ
    {
        
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Sicherheitsabstand_Primaertumor { get; set; }

        public decimal Tumordicke { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TumordickeSpecified { get; set; }

        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string LDH { get; set; }

        public JNU_Typ Ulzeration { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UlzerationSpecified { get; set; }
    }
}