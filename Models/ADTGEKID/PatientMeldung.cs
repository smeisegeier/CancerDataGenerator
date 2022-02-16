using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldung : AdtgekidBase
    {

        public PatientMeldung() { }

        [XmlElement(DataType = "date")] 
        public DateTime Meldedatum { get; set; }

        public PatientMeldungMeldebegruendung Meldebegruendung { get; set; }

        public PatientMeldungMeldeanlass Meldeanlass { get; set; }


        public PatientMeldungTumorzuordnung Tumorzuordnung { get; set; }

        public PatientMeldungDiagnose Diagnose { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("OP", IsNullable = false)]
        public PatientMeldungOP[] Menge_OP { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("ST", IsNullable = false)]
        public PatientMeldungST[] Menge_ST { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("SYST", IsNullable = false)]
        public PatientMeldungSYST[] Menge_SYST { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("Verlauf", IsNullable = false)]
        public List<PatientMeldungVerlauf> Menge_Verlauf { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("Zusatzitem", IsNullable = false)]
        public PatientMeldungZusatzitem[] Menge_Zusatzitem { get; set; }


        public string Anmerkung { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Meldung_ID { get; set; }

    }
}