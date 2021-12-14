using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Patient
    {
        public Patient()
        {
            Anmerkung = "lol";
            Patienten_Stammdaten = new Patienten_Stammdaten();
        }
        public Patienten_Stammdaten Patienten_Stammdaten { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Meldung", IsNullable = false)]
        public List<Meldung> Menge_Meldung { get; set; }

        
        public string Anmerkung { get; set; }
    }
}