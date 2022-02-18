using System;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Datum
    {
        public Datum(){}

        public Datum(DateTime date, Datumsgenauigkeit_Typ type)
        {
            Value = date;
            Datumsgenauigkeit = type.ToString();
        }

        [XmlAttribute]
        public string Datumsgenauigkeit { get; set; } 


        [XmlText(DataType = "date")]
        public DateTime Value { get; set; } 

    }
}