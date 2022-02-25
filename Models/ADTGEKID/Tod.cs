using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Tod : AdtgekidBase
    {
        public Datum Sterbedatum { get; set; }

        //public List<Todesursache> Menge_Todesursache { get; set; }

        public Todesursache Todesursache { get; set; }

        public int Anzahl_Tage_Diagnose_Tod { get; set; }
    }
}