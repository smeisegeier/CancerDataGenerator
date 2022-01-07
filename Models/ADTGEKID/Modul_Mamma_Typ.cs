using Rki.CancerDataGenerator.Models.Dimensions;

namespace Rki.CancerDataGenerator.Models.ADTGEKID
{
    public partial class Modul_Mamma_Typ : AdtgekidBase
    {
        public Modul_Mamma_Typ(){}

        public Modul_Mamma_Typ(IGenerator generator, AdtgekidBase parent) : base(generator, parent)
        {
            Praetherapeutischer_Menopausenstatus = _generator.FetchRandomEnumItem<Modul_Mamma_TypPraetherapeutischer_Menopausenstatus>();
            HormonrezeptorStatus_Oestrogen = _generator.FetchRandomEnumItem<Hormonrezeptor_Typ>();
            HormonrezeptorStatus_Progesteron = _generator.FetchRandomEnumItem<Hormonrezeptor_Typ>();
            Her2neuStatus = _generator.FetchRandomEnumItem<Hormonrezeptor_Typ>();
            PraeopDrahtmarkierung = _generator.FetchRandomEnumItem<Modul_Mamma_TypPraeopDrahtmarkierung>();
            IntraopPraeparatkontrolle = _generator.FetchRandomEnumItem<Modul_Mamma_TypIntraopPraeparatkontrolle>();
            TumorgroesseInvasiv = ((int)_generator.CreateNormalValueUponMean(230, 10)).ToString();
            TumorgroesseDCIS = ((int)_generator.CreateNormalValueUponMean(120, 10)).ToString();
        }
        public Modul_Mamma_TypPraetherapeutischer_Menopausenstatus Praetherapeutischer_Menopausenstatus { get; set; }

        
        public Hormonrezeptor_Typ HormonrezeptorStatus_Oestrogen { get; set; }

        
        public Hormonrezeptor_Typ HormonrezeptorStatus_Progesteron { get; set; }

        
        public Hormonrezeptor_Typ Her2neuStatus { get; set; }

        
        public Modul_Mamma_TypPraeopDrahtmarkierung PraeopDrahtmarkierung { get; set; }

       
        public Modul_Mamma_TypIntraopPraeparatkontrolle IntraopPraeparatkontrolle { get; set; }

        
        public string TumorgroesseInvasiv { get; set; }

       
        public string TumorgroesseDCIS { get; set; }
    }
}