namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungTumorzuordnung
    {
        
        public string Primaertumor_ICD_Code { get; set; }

        
        public ICD_Version_Typ Primaertumor_ICD_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Primaertumor_ICD_VersionSpecified { get; set; }

        
        public string Diagnosedatum { get; set; }

        
        public Seitenlokalisation_Typ Seitenlokalisation { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeitenlokalisationSpecified { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tumor_ID { get; set; }
    }
}