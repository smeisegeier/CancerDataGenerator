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

        [System.Xml.Serialization.XmlArrayItemAttribute("OP", IsNullable = false)]
        public OP[] Menge_OP { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("ST", IsNullable = false)]
        public ST[] Menge_ST { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("SYST", IsNullable = false)]
        public SYST[] Menge_SYST { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("Verlauf", IsNullable = false)]
        public List<Verlauf> Menge_Verlauf { get; set; }


        [System.Xml.Serialization.XmlArrayItemAttribute("Zusatzitem", IsNullable = false)]
        public Zusatzitem[] Menge_Zusatzitem { get; set; }


        public string Anmerkung { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Tumor_ID { get; set; }

    }
}