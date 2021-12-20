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
        DateTime CreateRandomDate_Meldedatum();
        Icd FetchNormalDimensionItem_Icd();
        Quote FetchRandomDimensionItem_Quote();
        ICD_Version_Typ FetchRandomEnumItem_IcdVersion();
        int GetDaysToPublishDate(DateTime start);
        int GetYearsToPublishDate(DateTime start);
        int GetMeldungCountPerAge(int age);
        DateTime CreateRandomDate_Geburtsdatum();
    }
}