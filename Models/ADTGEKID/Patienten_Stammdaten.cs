using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Patienten_Stammdaten : AdtgekidBase
    {

        public Patienten_Stammdaten() {}


        public PatientPatienten_StammdatenPatienten_Geschlecht Patienten_Geschlecht { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime Patienten_Geburtsdatum { get; set; }


        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Patient_ID { get; set; }


    }
}