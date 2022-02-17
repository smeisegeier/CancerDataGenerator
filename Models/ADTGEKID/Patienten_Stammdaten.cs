using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Patienten_Stammdaten : AdtgekidBase
    {

        public Patienten_Stammdaten() { }


        public PatientPatienten_StammdatenPatienten_Geschlecht Patienten_Geschlecht { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime Patienten_Geburtsdatum { get; set; }


        private string _Inzidenzort;
        public string Inzidenzort
        {
            get { return _Inzidenzort; }
            set { _Inzidenzort = Helper.StaticHelper.CheckIfSchemaElementMatchesRegex(value, @"\d{6}"); }
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Patient_ID { get; set; }


    }
}