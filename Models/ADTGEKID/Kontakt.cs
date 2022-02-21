namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Kontakt
    {
        public Zielgebiet Zielgebiet { get; set; }
        public Bestrahlung_Seite_Zielgebiet_Typ Seite_Zielgebiet { get; set; }
        public Bestrahlung_Applikationsart_Typ_Interstitiell_endokavitaer Interstitiell_endokavitaer { get; set; }
        public Bestrahlung_Applikationsart_Typ_Rate_Type Rate_Type { get; set; }
    }
}