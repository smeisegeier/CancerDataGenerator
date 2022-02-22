using System.ComponentModel.DataAnnotations;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Modul_Malignes_Melanom
    {
        [Range(0.1,99)]
        public double Tumordicke { get; set; }

        [Range(1, 10000)]
        public int LDH { get; set; }

    }
}