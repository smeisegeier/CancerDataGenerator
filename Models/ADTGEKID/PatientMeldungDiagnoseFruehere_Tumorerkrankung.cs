namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungDiagnoseFruehere_Tumorerkrankung
    {
        
        public string Freitext { get; set; }

        
        public string ICD_Code { get; set; }

        
        public ICD_Version_Typ ICD_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ICD_VersionSpecified { get; set; }

        
        public string Diagnosedatum { get; set; }
    }
}