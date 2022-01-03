using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldung : AdtgekidBase
    {

        public PatientMeldung(IGenerator generator, AdtgekidBase parent) : base(generator, parent)
        {
            Meldedatum = _generator.CreateRandomDate_Meldedatum().ToShortDateString();
            Meldebegruendung = _generator.FetchRandomEnumItem_Meldebegruendung();
            Meldeanlass = _generator.FetchRandomEnumItem_Meldeanlass();
            Diagnose = new PatientMeldungDiagnose(_generator, this);

            /* Tumorkonferenz */
            Menge_Tumorkonferenz = new List<PatientMeldungTumorkonferenz>();

            int i = 0;
            while (i < _generator.createRandomValue(0, 2))
            {
                Menge_Tumorkonferenz.Add(new PatientMeldungTumorkonferenz(_generator, this));
                i++;
            }

            /*  Verlauf*/ 
            Menge_Verlauf = new List<PatientMeldungVerlauf>();

            int j = 0;
            while (j < _generator.createRandomValue(0, 3))
            {
                Menge_Verlauf.Add(new PatientMeldungVerlauf(_generator, this));
                j++;
            }

            Meldung_ID = Guid.NewGuid().ToString();
        }
        public PatientMeldung() { }

        public string Meldedatum { get; set; }

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


        [System.Xml.Serialization.XmlArrayItemAttribute("Tumorkonferenz", IsNullable = false)]
        public List<PatientMeldungTumorkonferenz> Menge_Tumorkonferenz { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("Zusatzitem", IsNullable = false)]
        public PatientMeldungZusatzitem[] Menge_Zusatzitem { get; set; }


        public string Anmerkung { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Meldung_ID { get; set; }

        /*
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Melder_ID { get; set; }

        */
    }
}