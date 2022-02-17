using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Linq;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Diagnose : AdtgekidBase
    {
        public Diagnose(){}

        public Datum_Typ Diagnosedatum { get; set; }

        public string Primaertumor_ICD_Code { get; set; }
        
        public ICD_Version_Typ Primaertumor_ICD_Version { get; set; }

        public string Primaertumor_Diagnosetext { get; set; }

        
        public string Primaertumor_Topographie_ICD_O { get; set; }
        
        public PatientMeldungDiagnosePrimaertumor_Topographie_ICD_O_Version Primaertumor_Topographie_ICD_O_Version { get; set; }
        
        public string Primaertumor_Topographie_ICD_O_Freitext { get; set; }
        
       
        public PatientMeldungDiagnoseDiagnosesicherung Diagnosesicherung { get; set; }
        
        public Seitenlokalisation_Typ Seitenlokalisation { get; set; }

        
        [XmlArrayItem("Histologie", IsNullable = false)]
        public Histologie_Typ[] Menge_Histologie { get; set; }

        
        [XmlArrayItem("Fernmetastase", IsNullable = false)]
        public Menge_FM_TypFernmetastase[] Menge_FM { get; set; }

        
        public TNM_Typ cTNM { get; set; }

        
        public TNM_Typ pTNM { get; set; }

        
        [XmlArrayItem("Weitere_Klassifikation", IsNullable = false)]
        public Weitere_Klassifikation_Typ[] Menge_Weitere_Klassifikation { get; set; }

        
        public Modul_Mamma_Typ Modul_Mamma { get; set; }

        
        public Modul_Darm_Typ Modul_Darm { get; set; }

        
        public Modul_Prostata_Typ Modul_Prostata { get; set; }

        
        public Modul_Malignes_Melanom_Typ Modul_Malignes_Melanom { get; set; }

        
        public string Anmerkung { get; set; }

        
        [XmlAttribute()]
        public string Tumor_ID { get; set; }
    }
}