using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    // TODO Verlauf sill not clear
    public class Verlauf : AdtgekidBase
    {
        public Verlauf(){}

        public Histologie Histologie { get; set; }
        
        public TNM TNM { get; set; }
        
        [System.Xml.Serialization.XmlArrayItem("Weitere_Klassifikation", IsNullable = false)]
        public Weitere_Klassifikation[] Menge_Weitere_Klassifikation { get; set; }
        
        public string Untersuchungsdatum_Verlauf { get; set; }

        public PatientMeldungVerlaufGesamtbeurteilung_Tumorstatus Gesamtbeurteilung_Tumorstatus { get; set; }

        public PatientMeldungVerlaufVerlauf_Lokaler_Tumorstatus Verlauf_Lokaler_Tumorstatus { get; set; }

        public PatientMeldungVerlaufVerlauf_Tumorstatus_Lymphknoten Verlauf_Tumorstatus_Lymphknoten { get; set; }

        public PatientMeldungVerlaufVerlauf_Tumorstatus_Fernmetastasen Verlauf_Tumorstatus_Fernmetastasen { get; set; }

        [System.Xml.Serialization.XmlArrayItem("Fernmetastase", IsNullable = false)]
        public Fernmetastase[] Menge_FM { get; set; }


        public Modul_Prostata Modul_Prostata { get; set; }

        public Modul_Malignes_Melanom Modul_Malignes_Melanom { get; set; }

        public Tod Tod { get; set; }


        [System.Xml.Serialization.XmlAttribute()]
        public string Verlauf_ID { get; set; }
    }
}