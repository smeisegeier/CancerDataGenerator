namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Absender
    {
       
        public string Absender_Bezeichnung { get; set; }

        
        public string Absender_Ansprechpartner { get; set; }


        public string Absender_Anschrift { get; set; }


        public string Absender_Telefon { get; set; }


        public string Absender_EMail { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Absender_ID { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Software_ID { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Installations_ID { get; set; }
    }
}