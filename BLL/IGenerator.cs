using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataGenerator.DAL;
using Rki.CancerDataGenerator.Models.ADTGEKID;
using System;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.Dimensions
{
    [Obsolete]
    public interface IGenerator
    {
        int CreateFixedValuePatientCount();

        DateTime CreateRandomDate_Meldedatum();


        Quote FetchRandomDimensionItem_Quote();
        ICD_Version_Typ FetchRandomEnumItem_IcdVersion();
        int GetDaysToPublishDate(DateTime start);
        int GetYearsToPublishDate(DateTime start);
        int GetMeldungCountPerAge(int age);
        DateTime CreateRandomDate_Geburtsdatum();



        T FetchRandomEnumItem<T>() where T : Enum;

        PatientMeldungDiagnoseDiagnosesicherung FetchRandomEnumItem_Dsich();
        PatientMeldungMeldebegruendung FetchRandomEnumItem_Meldebegruendung();
        PatientMeldungMeldeanlass FetchRandomEnumItem_Meldeanlass();


        int createRandomValue(int min, int max);


        Icd FetchNormalDimensionItem_Icd(string chapter = "");


        double CreateNormalValueUponMean(double mean, double stdDev);
        int CreateNormalValueUponRange(int min, int max);


        T FetchRandomDimensionItem<T>(List<T> subset = null, double missingProb = 0) where T : DimensionBase;
    }
}