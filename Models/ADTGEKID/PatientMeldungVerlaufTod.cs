using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungVerlaufTod : AdtgekidBase
    {
        public PatientMeldungVerlaufTod(){}

        public string Sterbedatum { get; set; }

        public JNU_Typ Tod_tumorbedingt { get; set; }

        public PatientMeldungVerlaufTodMenge_Todesursache Menge_Todesursache { get; set; }
    }
}