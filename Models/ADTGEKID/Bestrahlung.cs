using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Bestrahlung
    {

        public Applikationsart Applikationsart { get; set; }
        //public Bestrahlung_Applikationsart_Typ Applikationsart { get; set; }

        [Range(0, Globals.MAXANZTAGEZWISCHENEREIGNISSE)]
        public int Anzahl_Tage_Diagnose_ST { get; set; }

        [Range(0, Globals.MAXANZTAGEZWISCHENEREIGNISSE)]
        public int Anzahl_Tage_ST_Dauer { get; set; }
    }
}