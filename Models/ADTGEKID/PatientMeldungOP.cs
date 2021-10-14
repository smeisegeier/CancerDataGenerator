namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungOP
    {

        
        public PatientMeldungOPOP_Intention OP_Intention { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OP_IntentionSpecified { get; set; }

        
        public string OP_Datum { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("OP_OPS", IsNullable = false)]
        public string[] Menge_OPS { get; set; }

        
        public PatientMeldungOPOP_OPS_Version OP_OPS_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OP_OPS_VersionSpecified { get; set; }

        
        public Histologie_Typ Histologie { get; set; }

        
        public TNM_Typ TNM { get; set; }

        
        public Residualstatus_Typ Residualstatus { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("OP_Komplikation", IsNullable = false)]
        public PatientMeldungOPOP_Komplikation[] Menge_Komplikation { get; set; }

        
        public Modul_Mamma_Typ Modul_Mamma { get; set; }
        
        public Modul_Darm_Typ Modul_Darm { get; set; }
        
        public Modul_Prostata_Typ Modul_Prostata { get; set; }

        
        public Modul_Malignes_Melanom_Typ Modul_Malignes_Melanom { get; set; }

        
        public Modul_Allgemein_Typ Modul_Allgemein { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Name_Operateur", IsNullable = false)]
        public string[] Menge_Operateur { get; set; }

        
        public string Anmerkung { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OP_ID { get; set; }
    }
}