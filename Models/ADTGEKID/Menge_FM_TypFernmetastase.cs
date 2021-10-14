namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Menge_FM_TypFernmetastase
    {
        
        public string FM_Diagnosedatum { get; set; }

        
        public Menge_FM_TypFernmetastaseFM_Lokalisation FM_Lokalisation { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FM_LokalisationSpecified { get; set; }
    }
}