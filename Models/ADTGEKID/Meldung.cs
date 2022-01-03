﻿using Rki.CancerDataGenerator.Models.Dimensions;
using System;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Meldung : AdtgekidBase
    {
        // TODO access parent properties

        public Meldung() { }

        public Meldung(IGenerator generator, AdtgekidBase parent) : base(generator, parent)
        {
            Meldedatum = _generator.CreateRandomDate(10 * 365, new DateTime(2000, 01, 01)).ToShortDateString();
            Diagnose = new PatientMeldungDiagnose(_generator, this);
        }

        public string Meldedatum { get; set; }


        public PatientMeldungMeldebegruendung Meldebegruendung { get; set; }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MeldebegruendungSpecified { get; set; }


        public PatientMeldungMeldeanlass Meldeanlass { get; set; }


        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MeldeanlassSpecified { get; set; }


        public PatientMeldungTumorzuordnung Tumorzuordnung { get; set; }


        public PatientMeldungDiagnose Diagnose { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("OP", IsNullable = false)]
        public PatientMeldungOP[] Menge_OP { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("ST", IsNullable = false)]
        public PatientMeldungST[] Menge_ST { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("SYST", IsNullable = false)]
        public PatientMeldungSYST[] Menge_SYST { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("Verlauf", IsNullable = false)]
        public PatientMeldungVerlauf[] Menge_Verlauf { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("Tumorkonferenz", IsNullable = false)]
        public PatientMeldungTumorkonferenz[] Menge_Tumorkonferenz { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("Zusatzitem", IsNullable = false)]
        public PatientMeldungZusatzitem[] Menge_Zusatzitem { get; set; }


        public string Anmerkung { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Meldung_ID { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Melder_ID { get; set; }
    }
}