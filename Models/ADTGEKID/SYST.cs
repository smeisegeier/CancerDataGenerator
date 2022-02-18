﻿namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class SYST
    {
        public PatientMeldungSYSTSYST_Intention SYST_Intention { get; set; }

        public PatientMeldungSYSTSYST_Stellung_OP SYST_Stellung_OP { get; set; }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SYST_Therapieart", IsNullable = false)]
        public PatientMeldungSYSTSYST_Therapieart[] Menge_Therapieart { get; set; }

        public string SYST_Therapieart_Anmerkung { get; set; }

        public string SYST_Protokoll { get; set; }
       
        [System.Xml.Serialization.XmlArrayItemAttribute("SYST_Substanz", IsNullable = false)]
        public string[] Menge_Substanz { get; set; }
        
        public PatientMeldungSYSTSYST_Ende_Grund SYST_Ende_Grund { get; set; }
        
        public Residualstatus Residualstatus { get; set; }

        public string Anmerkung { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SYST_ID { get; set; }
    }
}