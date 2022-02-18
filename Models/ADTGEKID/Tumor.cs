using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Tumor : AdtgekidBase
    {
        public Tumor() { }

        public Diagnose Primärdiagnose { get; set; }

        [XmlArrayItem("OP", IsNullable = false)]
        public OP[] Menge_OP { get; set; }

        [XmlArrayItem("ST", IsNullable = false)]
        public ST[] Menge_ST { get; set; }

        [XmlArrayItem("SYST", IsNullable = false)]
        public SYST[] Menge_SYST { get; set; }

        [XmlArrayItem("Folgeereignis", IsNullable = false)]
        public List<Verlauf> Menge_Folgeereignis { get; set; }

        [XmlAttribute()]
        public string Tumor_ID { get; set; }

    }
}