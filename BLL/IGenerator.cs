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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        int createRandomValue(int min, int max);

        /// <summary>
        /// Fetch ICD code -> can be null
        /// </summary>
        /// <param name="chapter">optional icd chapter</param>
        /// <returns>ICD code or null</returns>
        Icd FetchNormalDimensionItem_Icd(string chapter = "");


        /// <summary>
        /// Fetches RAW dimension item, no missing values considered.
        /// Based off of index numbers, not database id.
        /// </summary>
        /// <typeparam name="T">registered dimension</typeparam>
        /// <returns>dimension item</returns>
        //T FetchRandomDimensionItem<T>(List<T> subset = null) where T : DimensionBase;


        double CreateNormalValueUponMean(double mean, double stdDev);
        int CreateNormalValueUponRange(int min, int max);
        T FetchRandomDimensionItem<T>(List<T> subset = null, double missingProb = 0) where T : DimensionBase;
    }
}