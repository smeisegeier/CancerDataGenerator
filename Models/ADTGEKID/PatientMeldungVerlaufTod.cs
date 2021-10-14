namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungVerlaufTod
    {
        
        public string Sterbedatum { get; set; }


        public JNU_Typ Tod_tumorbedingt { get; set; }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Tod_tumorbedingtSpecified { get; set; }


        public PatientMeldungVerlaufTodMenge_Todesursache Menge_Todesursache { get; set; }
    }
}