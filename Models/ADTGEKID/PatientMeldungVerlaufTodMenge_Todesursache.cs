﻿using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class PatientMeldungVerlaufTodMenge_Todesursache : AdtgekidBase
    {
        public PatientMeldungVerlaufTodMenge_Todesursache(){}

        public PatientMeldungVerlaufTodMenge_Todesursache(Generator generator, AdtgekidBase parent) : base(generator, parent)
        {
            Todesursache_ICD = new List<string>();
            Todesursache_ICD.Add(_generator.FetchNormalDimensionItem<Icd>()?.icd_three_digits);
        }

        // if this decoration is missing, output has <string> elements :o
        [System.Xml.Serialization.XmlElementAttribute(nameof(Todesursache_ICD))]
        public List<string> Todesursache_ICD { get; set; }

        public ICD_Version_Typ Todesursache_ICD_Version { get; set; }
    }
}