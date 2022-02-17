using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator.Helper
{
    public static class StaticHelper
    {
        /// <summary>
        /// Exports a class to a formatted json string.
        /// </summary>
        /// <returns></returns>
        public static string ToJson(object obj) => JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
        public static T FromJson<T>(string json) => JsonConvert.DeserializeObject<T>(json);


        /// <summary>
        /// Serializes xml class object to string. All properties MUST have public setter
        /// </summary>
        /// <param name="model">Object to be serialized</param>
        /// <returns>xml as string</returns>
        public static string GetXmlStringFromObject(object model)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(model.GetType());
            StringWriter sw = new StringWriter();
            xmlSerializer.Serialize(sw, model);
            return sw.ToString();
        }


        public static string CheckIfSchemaElementMatchesRegex(string value, string regex)
        {
            if (!new Regex(regex).IsMatch(value))
            {
                // what to do if mismatch?
                throw new ArgumentException("Regex mismatch");
            }
            return value;
        }


        /// <summary>
        /// Validates xml string against referenced xsd. Requires xml and xsd to be in same namespace.
        /// </summary>
        /// <param name="xml">xml as string</param>
        /// <param name="xsdNamespace">namespace of xml and xsd</param>
        /// <param name="xsdPathRelative">relative path to xsd, eg "Models/schema.xsd"</param>
        /// <returns>List of ValidationMessageItem</returns>
        public static List<ValidationMessageItem> ValidateXml(string xml, string xsdNamespace, string xsdPathRelative)
        {
            // prepare xml doc and schema
            XDocument doc = XDocument.Parse(xml);
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(xsdNamespace, xsdPathRelative);

            // prepare settings in xmlreader. this is needed to include the warnings flag
            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            // or-include flag
            xmlReaderSettings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            xmlReaderSettings.Schemas = schemaSet;

            var messageItems = new List<ValidationMessageItem>();
            // handler is made anonymous, so it fits in static method
            xmlReaderSettings.ValidationEventHandler += (sender, e) =>
            {
                var validationMessage = new ValidationMessageItem();
                validationMessage.Severity = e.Severity.ToString();
                validationMessage.Message = e.Message;
                // local var is manipulated by handler
                messageItems.Add(validationMessage);
            };

            // assemble xml reader
            XmlReader xmlReader = XmlReader.Create(doc.CreateReader(), xmlReaderSettings);
            // loop through all xml nodes
            while (xmlReader.Read()) ;
            return messageItems;
        }

        /// <summary>
        /// Structure for Validation Messages.
        /// </summary>
        public struct ValidationMessageItem
        {
            /// <summary>
            /// Bases upon XmlSeverity enum, but those have no "None" element 
            /// </summary>
            public string Severity { get; set; }
            public string Message { get; set; }
            public override string ToString() => $"Severity: {Severity ?? "None"} | Message: {Message ?? "No Errors"}";

            /// <summary>
            /// Friendly display of all validation messages
            /// </summary>
            /// <param name="list">All items to print on screen</param>
            /// <returns>string</returns>
            public static string PrintItemList(List<ValidationMessageItem> list)
            {
                if (list is null || !list.Any())
                {
                    return "No entries.";
                }
                else
                {
                    return string.Join(Environment.NewLine, list.Select(x => x.ToString()));
                }
            }
        }
    }
}
