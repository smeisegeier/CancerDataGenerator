using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Modul_Mamma : AdtgekidBase
    {
        public Modul_Mamma(){}

        public Modul_Mamma_TypPraetherapeutischer_Menopausenstatus Praetherapeutischer_Menopausenstatus { get; set; }

        public Hormonrezeptor_Typ HormonrezeptorStatus_Oestrogen { get; set; }

        
        public Hormonrezeptor_Typ HormonrezeptorStatus_Progesteron { get; set; }

        public Hormonrezeptor_Typ Her2neuStatus { get; set; }
        
        public string TumorgroesseInvasiv { get; set; }
       
        public string TumorgroesseDCIS { get; set; }
    }
}