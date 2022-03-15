using System;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Dauer_DEPR
    {
        public Dauer_DEPR(){}

        public Dauer_DEPR(int anzahl)
        {
            Anzahl = anzahl;
            NU = default;
        }

        public Dauer_DEPR(JNU_Typ nu_Typ)
        {
            Anzahl = 0;
            NU = nu_Typ;
        }
        public JNU_Typ NU { get; set; } 

        public int Anzahl { get; set; } 

    }
}