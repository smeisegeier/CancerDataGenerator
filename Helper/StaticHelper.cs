using Newtonsoft.Json;

namespace Rki.CancerDataGenerator.Helper
{
    public static class StaticHelper
    {
        /// <summary>
        /// Exports a class to a formatted json string.
        /// </summary>
        /// <returns></returns>
        public static string ToJson(object obj) => JsonConvert.SerializeObject(obj, Formatting.Indented);
        public static T FromJson<T>(string json) => JsonConvert.DeserializeObject<T>(json);
    }
}
