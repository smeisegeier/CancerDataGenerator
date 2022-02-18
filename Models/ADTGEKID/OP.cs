namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class OP
    {

        
        public PatientMeldungOPOP_Intention OP_Intention { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("OP_OPS", IsNullable = false)]
        public string[] Menge_OPS { get; set; }

        
        public PatientMeldungOPOP_OPS_Version OP_OPS_Version { get; set; }

        
        public Histologie Histologie { get; set; }

        
        public TNM TNM { get; set; }

        
        public Residualstatus Residualstatus { get; set; }

        
        public Modul_Mamma Modul_Mamma { get; set; }
        
        public Modul_Darm Modul_Darm { get; set; }
        
        public Modul_Prostata Modul_Prostata { get; set; }

        
        public Modul_Malignes_Melanom Modul_Malignes_Melanom { get; set; }

      
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OP_ID { get; set; }
    }
}