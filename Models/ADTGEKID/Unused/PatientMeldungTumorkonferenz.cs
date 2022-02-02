using Rki.CancerDataGenerator.Models.Dimensions;
using System;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungTumorkonferenz : AdtgekidBase
    {

        public PatientMeldungTumorkonferenz(){}

        public string Tumorkonferenz_Datum { get; set; }

        public PatientMeldungTumorkonferenzTumorkonferenz_Typ Tumorkonferenz_Typ { get; set; }

        public string Anmerkung { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tumorkonferenz_ID { get; set; }
    }
}