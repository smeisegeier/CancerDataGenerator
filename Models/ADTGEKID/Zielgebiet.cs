using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Zielgebiet
    {
        // TODO bug nullable? try xmlchoice

        //[XmlElement(IsNullable = false)]
        public Bestrahlung_Zielgebiet_Typ? CodeVersion2021 { get; set; }

        //[XmlElement(IsNullable = false)]
        public Bestrahlung_Zielgebiet_Typ? CodeVersion2014 { get; set; }
    }
}