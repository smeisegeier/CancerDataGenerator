namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungVerlaufTodMenge_Todesursache
    {
        
        [System.Xml.Serialization.XmlElementAttribute("Todesursache_ICD")]
        public string[] Todesursache_ICD { get; set; }


        public ICD_Version_Typ Todesursache_ICD_Version { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Todesursache_ICD_VersionSpecified { get; set; }
    }
}