using Newtonsoft.Json;
using Rki.CancerDataModel.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Rki.CancerDataGenerator.StaticHelper
{
    public class Json
    {
        /// <summary>
        /// Fetch and deserialze classes that are given as json.
        /// Follows the convention: 
        /// - class MUST name as file.json
        /// - Folderpath must name as in code
        /// </summary>
        /// <typeparam name="T">class type</typeparam>
        /// <returns>list of all items in json object</returns>
        public static IEnumerable<T> ReadListFromJson<T>() where T : DimensionBase
        {
            var list = JsonConvert.DeserializeObject<List<T>>(
                File.ReadAllText(Path.Combine("Assets/Dimensions", $"{typeof(T).Name}.json")
                ));
            return list;
        }

        /// <summary>
        /// Auto increments all Id in Model objects. Overwrites.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listWithoutId"></param>
        /// <returns></returns>
        public static IEnumerable<T> AutoIncAllId<T>(IEnumerable<T> listWithoutId) where T : DimensionBase
        {
            int i = 1;
            listWithoutId
                .ToList()
                .ForEach(x =>
                {
                    x.Id = i++;
                });
            return listWithoutId;
        }
    }
}
