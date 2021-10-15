using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Rki.CancerDataGenerator.Models.Dimensions
{

    /// <summary>
    /// Base for Dimension classes.
    /// Naming patterns are disregarded here :o
    /// </summary>
    public class _DimensionBase
    {
        public int Id { get; set; }

        /// <summary>
        /// Fetch and deserialze classes that are given as json.
        /// Follows the convention: 
        /// - class MUST name as file.json
        /// - Folderpath must name as in code
        /// </summary>
        /// <typeparam name="T">class type</typeparam>
        /// <returns>list of all items in json object</returns>
        public static IEnumerable<T> ReadListFromJson<T>() where T : _DimensionBase
        {
            var list = JsonConvert.DeserializeObject<List<T>>(
                File.ReadAllText(Path.Combine("Models/Dimensions", $"{typeof(T).Name}.json")
                ));
            return list;
        }
    }
}
