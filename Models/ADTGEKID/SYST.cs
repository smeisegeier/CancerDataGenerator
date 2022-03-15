using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class SYST
    {
        public Datum Datum { get; set; }

        public SYST_Intention_Typ Intention { get; set; }

        public SYST_Stellung_OP_Typ Stellung_OP { get; set; }
        
        public SYST_Therapieart_Typ Therapieart { get; set; }

        public Protokoll Protokoll { get; set; }
       
        [System.Xml.Serialization.XmlArrayItem("Substanz", IsNullable = false)]
        public Substanz[] Menge_Substanz { get; set; }
        

        [Range(0, Globals.MAXANZTAGEZWISCHENEREIGNISSE)]
        public Dauer Anzahl_Tage_Diagnose_SYST { get; set; }

    }
}