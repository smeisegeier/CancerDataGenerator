using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungVerlaufTod : AdtgekidBase
    {
        public PatientMeldungVerlaufTod(){}

        public PatientMeldungVerlaufTod(IGenerator generator, AdtgekidBase parent) : base(generator, parent)
        {
            Sterbedatum = _generator.CreateRandomDate_Geburtsdatum().ToShortDateString();
            Tod_tumorbedingt = _generator.getRandomEnumItem<JNU_Typ>();
            Menge_Todesursache = new PatientMeldungVerlaufTodMenge_Todesursache(_generator, this);
        }
        public string Sterbedatum { get; set; }

        public JNU_Typ Tod_tumorbedingt { get; set; }

        public PatientMeldungVerlaufTodMenge_Todesursache Menge_Todesursache { get; set; }
    }
}