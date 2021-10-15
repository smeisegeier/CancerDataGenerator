﻿namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Patienten_Stammdaten
    {
        public string KrankenversichertenNr { get; set; }

        
        public string FamilienangehoerigenNr { get; set; }

        
        public string KrankenkassenNr { get; set; }

        
        public string Patienten_Nachname { get; set; }

        
        public string Patienten_Titel { get; set; }

        
        public string Patienten_Namenszusatz { get; set; }

        
        public string Patienten_Vornamen { get; set; }

        
        public string Patienten_Geburtsname { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Patienten_Frueherer_Name", IsNullable = false)]
        public string[] Menge_Frueherer_Name { get; set; }

        
        public PatientPatienten_StammdatenPatienten_Geschlecht Patienten_Geschlecht { get; set; }

        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Patienten_GeschlechtSpecified { get; set; }

        
        public string Patienten_Geburtsdatum { get; set; }

        
        [System.Xml.Serialization.XmlArrayItemAttribute("Adresse", IsNullable = false)]
        public PatientPatienten_StammdatenAdresse[] Menge_Adresse { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Patient_ID { get; set; }
    }
}