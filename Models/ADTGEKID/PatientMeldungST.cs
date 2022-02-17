namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungST
    {
        
        public PatientMeldungSTST_Intention ST_Intention { get; set; }

        public PatientMeldungSTST_Stellung_OP ST_Stellung_OP { get; set; }

        [System.Xml.Serialization.XmlArrayItemAttribute("Bestrahlung", IsNullable = false)]
        public PatientMeldungSTBestrahlung[] Menge_Bestrahlung { get; set; }

        public Residualstatus_Typ Residualstatus { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ST_ID { get; set; }
    }
}