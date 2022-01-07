using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;
using System.Linq;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Patient : AdtgekidBase
    {
        private int _meldungCount { get;}

        public Patient(Generator generator, AdtgekidBase adtgekidBase) : base(generator, adtgekidBase)
        {
            Anmerkung = _generator.FetchRandomDimensionItem<Quote>(null, _config.Text_ProbMissing)?.quote;
            Patienten_Stammdaten = new Patienten_Stammdaten(_generator, this);
            _meldungCount = _generator.GetMeldungCountPerAge(Patienten_Stammdaten._PatientAgeInYears);

            // TODO change loops like this
            Menge_Meldung = Enumerable
                .Range(1, 7)
                .Select(index => new PatientMeldung(_generator, this))
                .ToList();
        }

        public Patient() { }

        public Patienten_Stammdaten Patienten_Stammdaten { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Meldung", IsNullable = false)]
        public List<PatientMeldung> Menge_Meldung { get; set; }

        
        public string Anmerkung { get; set; }
    }
}