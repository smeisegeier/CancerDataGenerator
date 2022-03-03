namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class ST
    {
        public Datum Datum { get; set; }

        public ST_Intention_Typ Intention { get; set; }

        public ST_Stellung_OP_Typ Stellung_OP { get; set; }

        public Bestrahlung[] Menge_Bestrahlung { get; set; }
       
    }
}