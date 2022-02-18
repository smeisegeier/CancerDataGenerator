using System;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Datum
    {
        public Datum(){}

        /// <summary>
        /// Creates a xsd Datum_Typ object
        /// </summary>
        /// <param name="date">DateTime</param>
        /// <param name="type">T | E</param>
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