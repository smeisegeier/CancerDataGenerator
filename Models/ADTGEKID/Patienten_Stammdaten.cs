using Rki.CancerDataGenerator.Models.Dimensions;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Patienten_Stammdaten : AdtgekidBase
    {

        public Patienten_Stammdaten() {}
        public Patienten_Stammdaten(IGenerator generator, AdtgekidBase parent) : base(generator, parent)
        {
            Patienten_Geburtsdatum = _generator.CreateRandomDate(30*365).ToShortDateString();
            Patienten_Nachname = "Doe";
            Patienten_Vornamen = "John James";
            //TEST_tage_seit_diagnose = _NumericBase.GetRandomValue(11,65);
            TEST_tage_seit_diagnose = (int)_generator.CreateNormalValue(65, 10);
            //IEnumerable<double> lol = _NumericBase.GetNormalValues(65, 10, 10);
        }

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

        public int TEST_tage_seit_diagnose { get; set; }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Adresse", IsNullable = false)]
        public PatientPatienten_StammdatenAdresse[] Menge_Adresse { get; set; }

        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Patient_ID { get; set; }
    }
}