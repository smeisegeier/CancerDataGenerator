using System;
using System.Linq;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator
{
    public static class Extensions
    {
        public static string GetXmlAttributeFromEnumItem<T>(this T item) where T : struct, IConvertible
        {
            var attributeValue = ((XmlEnumAttribute)typeof(T)
                        .GetMember(item.ToString())[0]
                        .GetCustomAttributes(typeof(XmlEnumAttribute), false)[0])
                        .Name;
            return attributeValue;
        }

        public static string ToStringXmlEnum<T>(this T item) where T : struct, IConvertible
        {
            var enumType = typeof(T);
            if (!enumType.IsEnum) return null;//or string.Empty, or throw exception

            var member = enumType.GetMember(item.ToString()).FirstOrDefault();
            if (member == null) return null;//or string.Empty, or throw exception

            var attribute = member.GetCustomAttributes(false).OfType<XmlEnumAttribute>().FirstOrDefault();
            if (attribute == null) return null;//or string.Empty, or throw exception
            return attribute.Name;
        }

    }
}
