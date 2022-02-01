﻿using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Patient : AdtgekidBase
    {

        public Patient() { }

        public Patienten_Stammdaten Patienten_Stammdaten { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Meldung", IsNullable = false)]
        public List<PatientMeldung> Menge_Meldung { get; set; }

        
        public string Anmerkung { get; set; }
    }
}