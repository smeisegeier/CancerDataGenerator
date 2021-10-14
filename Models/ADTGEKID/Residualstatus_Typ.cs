namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Residualstatus_Typ
    {
        public R_Typ Lokale_Beurteilung_Residualstatus { get; set; }
        public bool Lokale_Beurteilung_ResidualstatusSpecified { get; set; }
        public R_Typ Gesamtbeurteilung_Residualstatus { get; set; }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Gesamtbeurteilung_ResidualstatusSpecified { get; set; }
    }
}