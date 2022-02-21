using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Diagnose : AdtgekidBase
    {

        public Datum Diagnosedatum { get; set; }

        [RegularExpression(@"[CD]\d\d(\.\d(\d) ?) ?|M72.4")]
        public string Primaertumor_ICD_Code { get; set; }
        
        public ICD_Version_Typ Primaertumor_ICD_Version { get; set; }

        [RegularExpression(@"C\d\d\.\d(\d)?")]
        public string Primaertumor_Topographie_ICD_O { get; set; }
        
        public PatientMeldungDiagnosePrimaertumor_Topographie_ICD_O_Version Primaertumor_Topographie_ICD_O_Version { get; set; }
        
       
        public PatientMeldungDiagnoseDiagnosesicherung Diagnosesicherung { get; set; }
        
        public Seitenlokalisation_Typ Seitenlokalisation { get; set; }

        
        public Histologie Histologie { get; set; }

        //[XmlArrayItem("Fernmetastase", IsNullable = false)]
        public List<Fernmetastase> Menge_FM { get; set; }

        
        public TNM cTNM { get; set; }

        
        public TNM pTNM { get; set; }

        
        [XmlArrayItem("Weitere_Klassifikation", IsNullable = false)]
        public Weitere_Klassifikation[] Menge_Weitere_Klassifikation { get; set; }

        
        public Modul_Mamma Modul_Mamma { get; set; }

        
        public Modul_Darm Modul_Darm { get; set; }

        
        public Modul_Prostata Modul_Prostata { get; set; }

        
        public Modul_Malignes_Melanom Modul_Malignes_Melanom { get; set; }

     }
}