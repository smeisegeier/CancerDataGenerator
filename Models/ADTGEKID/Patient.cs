using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Patient : AdtgekidBase
    {
        private int _meldungCount { get;}

        public Patient(IGenerator generator, AdtgekidBase adtgekidBase) : base(generator, adtgekidBase)
        {
            Anmerkung = _generator.FetchRandomDimensionItem_Quote()?.quote;
            Patienten_Stammdaten = new Patienten_Stammdaten(generator, this);
            _meldungCount = _generator.GetMeldungCountPerAge(Patienten_Stammdaten._PatientAgeInYears);

            Menge_Meldung = new List<Meldung>();
            for (int i = 0; i < _meldungCount; i++)
            {
                Menge_Meldung.Add(new Meldung(_generator, this));
            }

        }

        public Patient() { }

        public Patienten_Stammdaten Patienten_Stammdaten { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Meldung", IsNullable = false)]
        public List<Meldung> Menge_Meldung { get; set; }

        
        public string Anmerkung { get; set; }
    }
}