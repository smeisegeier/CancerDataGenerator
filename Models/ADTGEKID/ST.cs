namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class ST
    {
        
        public PatientMeldungSTST_Intention ST_Intention { get; set; }

        public PatientMeldungSTST_Stellung_OP ST_Stellung_OP { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Bestrahlung", IsNullable = false)]
        public Bestrahlung[] Menge_Bestrahlung { get; set; }

        public Residualstatus Residualstatus { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ST_ID { get; set; }
    }
}