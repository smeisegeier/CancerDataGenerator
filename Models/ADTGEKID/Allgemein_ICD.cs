using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Allgemein_ICD : AdtgekidBase
    {
        public string Code { get; set; }

        public ICD_Version_Typ Version { get; set; }
    }
}