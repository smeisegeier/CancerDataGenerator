using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Patienten_Stammdaten : AdtgekidBase
    {
        public Geschlecht_Typ Geschlecht { get; set; }

        public Datum Geburtsdatum { get; set; }

        [RegularExpression(@"\d{5}")]
        public string Inzidenzort { get; set; }

        public Tod Tod { get; set; }

        [XmlAttribute()]
        public string Patient_ID { get; set; }
    }
}