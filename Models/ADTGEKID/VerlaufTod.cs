using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class VerlaufTod : AdtgekidBase
    {
        public VerlaufTod(){}

        public string Sterbedatum { get; set; }

        public JNU_Typ Tod_tumorbedingt { get; set; }

        public VerlaufTodMenge_Todesursache Menge_Todesursache { get; set; }
    }
}