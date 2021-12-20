using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataGenerator.DAL;
using Rki.CancerDataGenerator.Models.ADTGEKID;
using System;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public interface IGenerator
    {
        int CreateFixedValuePatientCount();
        int CreateFixedValueMeldungCount();
        int CreateNormalValue(int min, int max);
        DateTime CreateRandomDate_Meldedatum();
        Icd GetNormalDimensionItemIcd();
        Quote GetRandomDimensionItemQuote();
        ICD_Version_Typ GetRandomEnumItemIcdVersion();
    }
}