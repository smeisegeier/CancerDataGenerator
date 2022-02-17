namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungOP
    {

        
        public PatientMeldungOPOP_Intention OP_Intention { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("OP_OPS", IsNullable = false)]
        public string[] Menge_OPS { get; set; }

        
        public PatientMeldungOPOP_OPS_Version OP_OPS_Version { get; set; }

        
        public Histologie_Typ Histologie { get; set; }

        
        public TNM_Typ TNM { get; set; }

        
        public Residualstatus_Typ Residualstatus { get; set; }

        
        public Modul_Mamma_Typ Modul_Mamma { get; set; }
        
        public Modul_Darm_Typ Modul_Darm { get; set; }
        
        public Modul_Prostata_Typ Modul_Prostata { get; set; }

        
        public Modul_Malignes_Melanom_Typ Modul_Malignes_Melanom { get; set; }

      
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OP_ID { get; set; }
    }
}