using Rki.CancerDataModel.Models;
using Rki.CancerDataModel.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator
{
    public static class Extensions
    {

        /// <summary>
        /// Returns XmlAttribute of a enum intem
        /// </summary>
        /// <typeparam name="T">enum type (inherent)</typeparam>
        /// <param name="item">item (inherent)</param>
        /// <returns>XmlEnumAttribute as string, null if error</returns>
        public static string ToStringXmlEnum<T>(this T item) where T : Enum
        {
            var enumType = typeof(T);
            var member = enumType.GetMember(item.ToString()).FirstOrDefault();
            if (member == null) 
                return null;            // or string.Empty, or throw exception

            var attribute = member.GetCustomAttributes(false).OfType<XmlEnumAttribute>().FirstOrDefault();
            if (attribute == null)
                return null;            // item.ToString(); // no description available
            return attribute.Name;
        }

        public static IEnumerable<T> AutoIncAllId<T>(this IEnumerable<T> listWithoutId) where T : DimensionBase
            => DimensionBase.AutoIncAllId<T>(listWithoutId);

    }
}
