using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class OP
    {

        public Datum Datum { get; set; }

        public OP_Intention_Typ Intention { get; set; }

        //[System.Xml.Serialization.XmlArrayItem("OPS", IsNullable = false)]
        public List<OPS> Menge_OPS { get; set; }
        
        public Residualstatus Residualstatus { get; set; }

        [Range(0, Globals.MAXANZTAGEZWISCHENEREIGNISSE)]
        public Dauer Anzahl_Tage_Diagnose_OP { get; set; }

    }
}