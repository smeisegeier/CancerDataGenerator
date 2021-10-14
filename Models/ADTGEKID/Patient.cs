namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Patient
    {
        
        public PatientPatienten_Stammdaten Patienten_Stammdaten { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Meldung", IsNullable = false)]
        public PatientMeldung[] Menge_Meldung { get; set; }

        
        public string Anmerkung { get; set; }
    }
}