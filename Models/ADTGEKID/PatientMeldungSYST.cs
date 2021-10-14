namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungSYST
    {
        public PatientMeldungSYSTSYST_Intention SYST_Intention { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SYST_IntentionSpecified { get; set; }

        
        public PatientMeldungSYSTSYST_Stellung_OP SYST_Stellung_OP { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SYST_Stellung_OPSpecified { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("SYST_Therapieart", IsNullable = false)]
        public PatientMeldungSYSTSYST_Therapieart[] Menge_Therapieart { get; set; }

        
        public string SYST_Therapieart_Anmerkung { get; set; }

        
        public string SYST_Protokoll { get; set; }

        
        public string SYST_Beginn_Datum { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("SYST_Substanz", IsNullable = false)]
        public string[] Menge_Substanz { get; set; }

        
        public PatientMeldungSYSTSYST_Ende_Grund SYST_Ende_Grund { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SYST_Ende_GrundSpecified { get; set; }

        
        public string SYST_Ende_Datum { get; set; }

        
        public Residualstatus_Typ Residualstatus { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("SYST_Nebenwirkung", IsNullable = false)]
        public Nebenwirkung_Typ[] Menge_Nebenwirkung { get; set; }

        
        public Modul_Allgemein_Typ Modul_Allgemein { get; set; }

        
        public string Anmerkung { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SYST_ID { get; set; }
    }
}