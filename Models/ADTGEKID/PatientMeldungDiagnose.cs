using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Linq;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungDiagnose : AdtgekidBase
    {
        public PatientMeldungDiagnose(){}

        public PatientMeldungDiagnose(IGenerator generator, AdtgekidBase parent) : base(generator, parent)
        {
            // TODO make ICD dependant on ICD-Version
            Primaertumor_ICD_Code = _generator.FetchNormalDimensionItem_Icd()?.icd_three_digits;
            Primaertumor_ICD_Version_ = _generator.FetchRandomEnumItem_IcdVersion().ToStringXmlEnum();
            Primaertumor_Diagnosetext = _generator.FetchRandomDimensionItem_Quote()?.quote;
        }

        public string Primaertumor_ICD_Code { get; set; }
        
        public ICD_Version_Typ Primaertumor_ICD_Version { get; set; }

        // "Specified" annex causes bug in serializer. MUST be removed, up to now it is of no use.  
        //[System.Xml.Serialization.XmlIgnoreAttribute()]
        //public bool Primaertumor_ICD_VersionSpecified { get; set; }


        public string Primaertumor_Diagnosetext { get; set; }

        
        public string Primaertumor_Topographie_ICD_O { get; set; }

        
        public PatientMeldungDiagnosePrimaertumor_Topographie_ICD_O_Version Primaertumor_Topographie_ICD_O_Version { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Primaertumor_Topographie_ICD_O_VersionSpecified { get; set; }

        
        public string Primaertumor_Topographie_ICD_O_Freitext { get; set; }

        
        public string Diagnosedatum { get; set; }

        
        public PatientMeldungDiagnoseDiagnosesicherung Diagnosesicherung { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiagnosesicherungSpecified { get; set; }

        
        public Seitenlokalisation_Typ Seitenlokalisation { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeitenlokalisationSpecified { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Fruehere_Tumorerkrankung", IsNullable = false)]
        public PatientMeldungDiagnoseFruehere_Tumorerkrankung[] Menge_Fruehere_Tumorerkrankung { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Histologie", IsNullable = false)]
        public Histologie_Typ[] Menge_Histologie { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Fernmetastase", IsNullable = false)]
        public Menge_FM_TypFernmetastase[] Menge_FM { get; set; }

        
        public TNM_Typ cTNM { get; set; }

        
        public TNM_Typ pTNM { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Weitere_Klassifikation", IsNullable = false)]
        public Menge_Weitere_Klassifikation_TypWeitere_Klassifikation[] Menge_Weitere_Klassifikation { get; set; }

        
        public Modul_Mamma_Typ Modul_Mamma { get; set; }

        
        public Modul_Darm_Typ Modul_Darm { get; set; }

        
        public Modul_Prostata_Typ Modul_Prostata { get; set; }

        
        public Modul_Malignes_Melanom_Typ Modul_Malignes_Melanom { get; set; }

        
        public Modul_Allgemein_Typ Modul_Allgemein { get; set; }

        
        public Allgemeiner_Leistungszustand_Typ Allgemeiner_Leistungszustand { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Allgemeiner_LeistungszustandSpecified { get; set; }
        
        public string Anmerkung { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tumor_ID { get; set; }
    }
}