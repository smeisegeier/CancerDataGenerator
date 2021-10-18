using System;
using System.IO;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator
{
    public static class Globals
    {

        /// <summary>
        /// Serializes xml class object to string. All properties MUST have public setter
        /// </summary>
        /// <param name="model">Object to be serialized</param>
        /// <param name="root">e.g. "Training"</param>
        /// <returns>xml as string</returns>
        public static string GetXmlStringFromObject(object model)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(model.GetType());
            StringWriter sw = new StringWriter();
            xmlSerializer.Serialize(sw, model);
            return sw.ToString();
        }
    }
}
