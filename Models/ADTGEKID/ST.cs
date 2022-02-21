namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class ST
    {
        public ST_Intention_Typ ST_Intention { get; set; }

        public ST_Stellung_OP_Typ ST_Stellung_OP { get; set; }

        public Bestrahlung[] Menge_Bestrahlung { get; set; }

        public Residualstatus Residualstatus { get; set; }
       
    }
}