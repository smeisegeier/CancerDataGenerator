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

        public Datum Datum { get; set; }


        public Tumor_ICD Primaertumor_ICD { get; set; }

        public Topographie_ICD Primaertumor_Topographie_ICD_O { get; set; }


        public Diagnosesicherung_Typ Diagnosesicherung { get; set; }
        
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

        public DCI_Typ DCI { get; set; }

        public int Anzahl_Tage_Diagnose_Tod { get; set; }

    }
}