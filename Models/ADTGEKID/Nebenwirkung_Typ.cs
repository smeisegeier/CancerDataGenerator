namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Nebenwirkung_Typ
    {
       
        public Nebenwirkung_TypNebenwirkung_Grad Nebenwirkung_Grad { get; set; }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Nebenwirkung_GradSpecified { get; set; }

        public string Nebenwirkung_Art { get; set; }


        public Nebenwirkung_TypNebenwirkung_Version Nebenwirkung_Version { get; set; }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Nebenwirkung_VersionSpecified { get; set; }
    }
}