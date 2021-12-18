using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Patient : AdtgekidBase
    {
        public Patient() { }

        public Patient(IGenerator generator, AdtgekidBase adtgekidBase) : base(generator, adtgekidBase)
        {
            Anmerkung = "gh";//_generator.GetRandomQuote();
            Patienten_Stammdaten = new Patienten_Stammdaten(generator, this);

            Menge_Meldung = new List<Meldung>();
            for (int i = 0; i < _generator.CreateRandomValue(1, 3); i++)
            {
                Menge_Meldung.Add(new Meldung(_generator, this));
            }

        }
        public Patienten_Stammdaten Patienten_Stammdaten { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Meldung", IsNullable = false)]
        public List<Meldung> Menge_Meldung { get; set; }

        
        public string Anmerkung { get; set; }
    }
}