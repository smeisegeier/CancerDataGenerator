namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    // TODO item vs enum
    public partial class Modul_Prostata_TypCaBefallStanze
    {
        [System.Xml.Serialization.XmlElementAttribute("Prozentzahl", typeof(string), DataType = "positiveInteger")]
        [System.Xml.Serialization.XmlElementAttribute("U", typeof(Modul_Prostata_TypCaBefallStanzeU))]
        public object Item { get; set; }
    }
}