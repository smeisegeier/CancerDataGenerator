using Rki.CancerDataGenerator.DAL;
using System;
using System.Collections.Generic;

namespace Rki.CancerDataGenerator.Models.Dimensions
{
    public interface IGenerator
    {
        T GetNormalDimensionItem<T>() where T : DimensionBase;
        int CreateNormalValue(int min, int max);
        double CreateNormalValue(double mean, double stdDev);
        DateTime CreateRandomDate(int deltaDays);
        DateTime CreateRandomDate(int deltaDays, DateTime baseDate);
        T GetRandomEnumItem<T>() where T : Enum;
        int CreateRandomValue(int delta);
        int CreateRandomValue(int min, int max);
        T GetRandomDimensionItem<T>() where T : DimensionBase;
    }
}