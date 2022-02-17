using System;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Datum_Typ
    {
        public Datum_Typ(){}

        public Datum_Typ(DateTime date, Datumsgenauigkeit_Typ type)
        {
            Datum = date;
            Datumsgenauigkeit = type.ToString();
        }

        [XmlAttribute]
        public string Datumsgenauigkeit { get; set; } 


        [XmlText(DataType = "date")]
        public DateTime Datum { get; set; } 

    }
}