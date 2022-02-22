using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public class Modul_Mamma : AdtgekidBase
    {
        public Modul_Mamma(){}

        public Praetherapeutischer_Menopausenstatus_Typ Praetherapeutischer_Menopausenstatus { get; set; }

        public Hormonrezeptor_Typ HormonrezeptorStatus_Oestrogen { get; set; }

        
        public Hormonrezeptor_Typ HormonrezeptorStatus_Progesteron { get; set; }

        public Hormonrezeptor_Typ Her2neuStatus { get; set; }
        
        public string TumorgroesseInvasiv { get; set; }
       
        public string TumorgroesseDCIS { get; set; }
    }
}