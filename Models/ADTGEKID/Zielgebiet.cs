using System.ComponentModel;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Zielgebiet
    {
        [DefaultValue(Bestrahlung_Zielgebiet_Typ.Default)]
        public Bestrahlung_Zielgebiet_Typ CodeVersion2021 { get; set; }

        [DefaultValue(Bestrahlung_Zielgebiet_Typ.Default)]
        public Bestrahlung_Zielgebiet_Typ CodeVersion2014 { get; set; }
    }
}