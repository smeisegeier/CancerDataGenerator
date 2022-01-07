using Rki.CancerDataGenerator.Models.Dimensions;
using System;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungTumorkonferenz : AdtgekidBase
    {
        public PatientMeldungTumorkonferenz(Generator generator, AdtgekidBase parent) : base(generator, parent)
        {
            Anmerkung = _generator.FetchRandomDimensionItem<Quote>(null, _config.Text_ProbMissing)?.quote;
            Tumorkonferenz_Datum = _generator.CreateRandomDate_Meldedatum().ToShortDateString();
            Tumorkonferenz_Typ = _generator.FetchRandomEnumItem<PatientMeldungTumorkonferenzTumorkonferenz_Typ>();
            Tumorkonferenz_ID = Guid.NewGuid().ToString();
        }

        public PatientMeldungTumorkonferenz(){}

        public string Tumorkonferenz_Datum { get; set; }

        public PatientMeldungTumorkonferenzTumorkonferenz_Typ Tumorkonferenz_Typ { get; set; }

        public string Anmerkung { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tumorkonferenz_ID { get; set; }
    }
}