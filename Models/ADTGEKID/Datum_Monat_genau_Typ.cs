using System;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Datum_Monat_genau_Typ
    {
        [System.Xml.Serialization.XmlElement(DataType = "date")]
        [System.Xml.Serialization.XmlElementAttribute("T", typeof(Datumsgenauigkeit_Typ))]
        public DateTime Datum { get; set; }
    }
}