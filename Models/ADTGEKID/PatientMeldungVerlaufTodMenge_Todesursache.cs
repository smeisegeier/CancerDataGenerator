using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class PatientMeldungVerlaufTodMenge_Todesursache : AdtgekidBase
    {
        public PatientMeldungVerlaufTodMenge_Todesursache(){}

        public PatientMeldungVerlaufTodMenge_Todesursache(IGenerator generator, AdtgekidBase parent) : base(generator, parent)
        {
            Todesursache_ICD = new List<string>();
            Todesursache_ICD.Add(_generator.FetchNormalDimensionItem_Icd()?.icd_three_digits);
        }

        [System.Xml.Serialization.XmlElementAttribute("Todesursache_ICD")]
        public List<string> Todesursache_ICD { get; set; }

        public ICD_Version_Typ Todesursache_ICD_Version { get; set; }
    }
}