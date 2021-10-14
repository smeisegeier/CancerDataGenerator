namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungTumorkonferenz
    {
     
        public string Tumorkonferenz_Datum { get; set; }

        public PatientMeldungTumorkonferenzTumorkonferenz_Typ Tumorkonferenz_Typ { get; set; }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Tumorkonferenz_TypSpecified { get; set; }


        public string Anmerkung { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tumorkonferenz_ID { get; set; }
    }
}