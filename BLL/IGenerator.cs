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
        int CreateNormalValue(int min, int max);
        double CreateNormalValue(double mean, double stdDev);
        DateTime CreateRandomDate(int deltaDays);
        DateTime CreateRandomDate(int deltaDays, DateTime baseDate);
        int CreateRandomValue(int delta);
        int CreateRandomValue(int min, int max);
        Icd GetNormalDimensionItemIcd();
        Quote GetRandomDimensionItemQuote();
        ICD_Version_Typ GetRandomEnumItemIcdVersion();
    }
}