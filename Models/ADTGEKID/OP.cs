using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class OP
    {

        public OP_Intention_Typ OP_Intention { get; set; }

       
        [System.Xml.Serialization.XmlArrayItem("OPS", IsNullable = false)]
        public string[] Menge_OPS { get; set; }
        
        public Residualstatus Residualstatus { get; set; }

        [Range(0, Globals.MAXANZTAGEZWISCHENEREIGNISSE)]
        public int Anzahl_Tage_Diagnose_OP { get; set; }

        [Range(0, Globals.MAXANZTAGEZWISCHENEREIGNISSE)]
        public int Anzahl_Tage_OP_Dauer { get; set; }

    }
}