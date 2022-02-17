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


        public PatientPatienten_StammdatenPatienten_Geschlecht Patienten_Geschlecht { get; set; }

        public Datum_Typ Patienten_Geburtsdatum { get; set; }


        // TODO needs refinement
        private string _Inzidenzort;
        public string Inzidenzort
        {
            get { return _Inzidenzort; }
            set { _Inzidenzort = Helper.StaticHelper.CheckIfSchemaElementMatchesRegex(value, @"\d{5}"); }
        }

        [XmlAttribute()]
        public string Patient_ID { get; set; }


    }
}