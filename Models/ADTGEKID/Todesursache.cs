using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Todesursache : AdtgekidBase
    {
        public Todesursache(){}

        public string Todesursache_ICD { get; set; }

        public ICD_Version_Typ Todesursache_ICD_Version { get; set; }
    }
}