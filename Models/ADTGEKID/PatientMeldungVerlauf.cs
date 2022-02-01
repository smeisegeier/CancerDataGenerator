using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class PatientMeldungVerlauf : AdtgekidBase
    {
        public PatientMeldungVerlauf(){}

        public Histologie_Typ Histologie { get; set; }
        
        public TNM_Typ TNM { get; set; }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Weitere_Klassifikation", IsNullable = false)]
        public Menge_Weitere_Klassifikation_TypWeitere_Klassifikation[] Menge_Weitere_Klassifikation { get; set; }
        
        public string Untersuchungsdatum_Verlauf { get; set; }

        public PatientMeldungVerlaufGesamtbeurteilung_Tumorstatus Gesamtbeurteilung_Tumorstatus { get; set; }

        public PatientMeldungVerlaufVerlauf_Lokaler_Tumorstatus Verlauf_Lokaler_Tumorstatus { get; set; }

        public PatientMeldungVerlaufVerlauf_Tumorstatus_Lymphknoten Verlauf_Tumorstatus_Lymphknoten { get; set; }

        public PatientMeldungVerlaufVerlauf_Tumorstatus_Fernmetastasen Verlauf_Tumorstatus_Fernmetastasen { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Fernmetastase", IsNullable = false)]
        public Menge_FM_TypFernmetastase[] Menge_FM { get; set; }

        public Allgemeiner_Leistungszustand_Typ Allgemeiner_Leistungszustand { get; set; }

        public Modul_Prostata_Typ Modul_Prostata { get; set; }

        public Modul_Malignes_Melanom_Typ Modul_Malignes_Melanom { get; set; }

        public Modul_Allgemein_Typ Modul_Allgemein { get; set; }

        public PatientMeldungVerlaufTod Tod { get; set; }

        public string Anmerkung { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Verlauf_ID { get; set; }
    }
}