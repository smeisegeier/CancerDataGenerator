using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Tod : AdtgekidBase
    {
        public Tod(){}

        public Datum Sterbedatum { get; set; }

        public Todesursache Todesursache { get; set; }
    }
}