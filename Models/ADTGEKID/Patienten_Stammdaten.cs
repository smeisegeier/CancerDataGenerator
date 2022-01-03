﻿using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Patienten_Stammdaten : AdtgekidBase
    {

        public Patienten_Stammdaten() {}
        public Patienten_Stammdaten(IGenerator generator, AdtgekidBase parent) : base(generator, parent)
        {
            Patienten_Geburtsdatum = _generator.CreateRandomDate(30*365).ToShortDateString();
            Patienten_Geschlecht = _generator.GetRandomEnumItem<PatientPatienten_StammdatenPatienten_Geschlecht>();
        }

        public PatientPatienten_StammdatenPatienten_Geschlecht Patienten_Geschlecht { get; set; }

        public string Patienten_Geburtsdatum { get; set; }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Patient_ID { get; set; }

        /*
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

        [System.Xml.Serialization.XmlArrayItemAttribute("Adresse", IsNullable = false)]
        public PatientPatienten_StammdatenAdresse[] Menge_Adresse { get; set; }  


         */

    }
}