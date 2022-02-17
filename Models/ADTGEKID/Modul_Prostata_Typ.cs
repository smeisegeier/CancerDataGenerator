namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Modul_Prostata_Typ
    {
        public Modul_Prostata_TypGleasonScore GleasonScore { get; set; }

        public Datum_Typ DatumStanzen { get; set; }

        public decimal PSA { get; set; }
    }
}