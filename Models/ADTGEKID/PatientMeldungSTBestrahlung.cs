namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class PatientMeldungSTBestrahlung
    {
        
        public PatientMeldungSTBestrahlungST_Zielgebiet ST_Zielgebiet { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ST_ZielgebietSpecified { get; set; }
        
        public PatientMeldungSTBestrahlungST_Seite_Zielgebiet ST_Seite_Zielgebiet { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ST_Seite_ZielgebietSpecified { get; set; }

        
        public string ST_Beginn_Datum { get; set; }

        
        public string ST_Ende_Datum { get; set; }

        
        public PatientMeldungSTBestrahlungST_Applikationsart ST_Applikationsart { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ST_ApplikationsartSpecified { get; set; }

        
        public Strahlendosis_Typ ST_Gesamtdosis { get; set; }

        
        public Strahlendosis_Typ ST_Einzeldosis { get; set; }
    }
}