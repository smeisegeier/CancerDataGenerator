namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Perkutan
    {
        public Zielgebiet Zielgebiet { get; set; }
        public Bestrahlung_Seite_Zielgebiet_Typ Seite_Zielgebiet { get; set; }
        public Bestrahlung_Applikationsart_Typ_Radiochemo Radiochemo { get; set; }
        public Bestrahlung_Applikationsart_Typ_Stereotaktisch Stereotaktisch { get; set; }
        public Bestrahlung_Applikationsart_Typ_Atemgetriggert Atemgetriggert { get; set; }
    }
}