using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Todesursache : AdtgekidBase
    {
        public Todesursache(){}

        // if this decoration is missing, output has <string> elements :o
        [System.Xml.Serialization.XmlElement(nameof(Todesursache_ICD))]
        public List<string> Todesursache_ICD { get; set; }

        public ICD_Version_Typ Todesursache_ICD_Version { get; set; }
    }
}