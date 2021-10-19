using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Rki.CancerDataGenerator
{
    public static class Globals
    {
        public const string XSDPATHRELATIVE = "Models/ADT_GEKID_v2.2.1.xsd";
        public const string XSDNAMESPACE = "http://www.gekid.de/namespace";



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


        //public static List<ValidationMessageItem> ValidateXml(string xml, string xsdNamespace, string xsdPathRelative)
        //{
        //    XDocument doc = XDocument.Parse(xml);
        //    XmlSchemaSet schemaSet = new XmlSchemaSet();
        //    schemaSet.Add(xsdNamespace, xsdPathRelative);

        //    XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
        //    xmlReaderSettings.ValidationType = ValidationType.Schema;
        //    xmlReaderSettings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;

        //    var messageItems = new List<ValidationMessageItem>();
        //    xmlReaderSettings.ValidationEventHandler += (sender, e) => ValidationEventHandler(sender, e, messageItems);

        //    xmlReaderSettings.Schemas = schemaSet;
        //    XmlReader xmlReader = XmlReader.Create(doc.CreateReader(), xmlReaderSettings);
        //    while (xmlReader.Read()) ;
        //    return messageItems;
        //}

        //public void ValidationEventHandler(object sender, ValidationEventArgs e, List<ValidationMessageItem> messageItems)
        //{
        //    var validationMessage = new ValidationMessageItem();
        //    validationMessage.Severity = e.Severity.ToString();
        //    validationMessage.Message = e.Message;

        //    messageItems.Add(validationMessage);
        //}

        //public class ValidationMessageItem
        //{
        //    public string Severity { get; set; }
        //    public string Message { get; set; }
        //    public override string ToString() => $"Severity: {Severity ?? "None"} | Message: {Message ?? "No Errors"}";

        //    public static string PrintItemList(List<ValidationMessageItem> list)
        //    {
        //        if (list is null || !list.Any())
        //        {
        //            return "No errors";
        //        }
        //        else
        //        {
        //            return string.Join(Environment.NewLine, list.Select(x => x.ToString()));
        //        }
        //    }
        //}

    }
}
