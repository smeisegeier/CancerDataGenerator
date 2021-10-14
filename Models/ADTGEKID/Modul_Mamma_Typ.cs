namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Modul_Mamma_Typ
    {

        
        public Modul_Mamma_TypPraetherapeutischer_Menopausenstatus Praetherapeutischer_Menopausenstatus { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Praetherapeutischer_MenopausenstatusSpecified { get; set; }

        
        public Hormonrezeptor_Typ HormonrezeptorStatus_Oestrogen { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HormonrezeptorStatus_OestrogenSpecified { get; set; }

        
        public Hormonrezeptor_Typ HormonrezeptorStatus_Progesteron { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HormonrezeptorStatus_ProgesteronSpecified { get; set; }

        
        public Hormonrezeptor_Typ Her2neuStatus { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Her2neuStatusSpecified { get; set; }

        
        public Modul_Mamma_TypPraeopDrahtmarkierung PraeopDrahtmarkierung { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PraeopDrahtmarkierungSpecified { get; set; }

        
        public Modul_Mamma_TypIntraopPraeparatkontrolle IntraopPraeparatkontrolle { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IntraopPraeparatkontrolleSpecified { get; set; }

        
        public string TumorgroesseInvasiv { get; set; }

        
        public string TumorgroesseDCIS { get; set; }
    }
}