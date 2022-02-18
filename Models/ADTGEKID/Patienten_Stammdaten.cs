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

        public Patienten_Stammdaten() { }


        public Geschlecht_Typ Geschlecht { get; set; }

        public Datum Geburtsdatum { get; set; }


        // TODO needs refinement
        private string _Inzidenzort;
        public string Inzidenzort
        {
            get { return _Inzidenzort; }
            set { _Inzidenzort = Helper.StaticHelper.CheckIfSchemaElementMatchesRegex(value, @"\d{5}"); }
        }

        public Tod Tod { get; set; }

        [XmlAttribute()]
        public string Patient_ID { get; set; }


    }
}