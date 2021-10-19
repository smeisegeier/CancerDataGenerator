using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rki.CancerDataGenerator.Models;
using Rki.CancerDataGenerator.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Rki.CancerDataGenerator.DAL;
using Rki.CancerDataGenerator.Models.ADTGEKID;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;

namespace Rki.CancerDataGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AdtGekidDbContext _context;

        public HomeController(ILogger<HomeController> logger, AdtGekidDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index() => View();

        public IActionResult Details()
        {
            ADT_GEKID a = getNewRootObject();

            return Content(Globals.GetXmlStringFromObject(a));

            //return Json(a);
        }

        // TODO -> module
        public IActionResult Validate()
        {
            ADT_GEKID a = getNewRootObject();
            var serial = Globals.GetXmlStringFromObject(a);

            XDocument xml = XDocument.Parse(serial);
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add(Globals.XSDNAMESPACE, Globals.XSDPATHRELATIVE);

            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;

            var messageItems = new List<ValidationMessageItem>();
            xmlReaderSettings.ValidationEventHandler += (sender, e) => ValidationEventHandler(sender, e, messageItems);

            xmlReaderSettings.Schemas = schemaSet;
            XmlReader xmlReader = XmlReader.Create(xml.CreateReader(), xmlReaderSettings);
            while (xmlReader.Read()) ;
            return Content(ValidationMessageItem.PrintItemList(messageItems));
        }

        public void ValidationEventHandler(object sender, ValidationEventArgs e, List<ValidationMessageItem> messageItems)
        {
            var validationMessage = new ValidationMessageItem();
            validationMessage.Severity = e.Severity.ToString();
            validationMessage.Message = e.Message;

            messageItems.Add(validationMessage);
        }

        public class ValidationMessageItem
        {
            public string Severity { get; set; }
            public string Message { get; set; }
            public override string ToString() => $"Severity: {Severity ?? "None"} | Message: {Message ?? "No Errors"}";

            public static string PrintItemList(List<ValidationMessageItem> list)
            {
                if (list is null || !list.Any())
                {
                    return "No errors";
                }
                else
                {
                    return string.Join(Environment.NewLine, list.Select(x => x.ToString()));
                }
            }
        }




        private static ADT_GEKID getNewRootObject()
        {
            var a = new ADT_GEKID();
            a.Menge_Patient = new List<Patient>();
            a.Schema_Version = Schema_Version.Item211;
            var pat = new Patient();
            pat.Anmerkung = "lol";
            pat.Patienten_Stammdaten = new Patienten_Stammdaten();
            pat.Patienten_Stammdaten.Patienten_Geburtsdatum = "12.07.1980";
            pat.Patienten_Stammdaten.Patienten_Nachname = "Doe";
            pat.Patienten_Stammdaten.Patienten_Vornamen = "John James";
            var meld = new Meldung();
            pat.Menge_Meldung = new List<Meldung>();
            pat.Menge_Meldung.Add(meld);
            a.Menge_Patient.Add(pat);
            return a;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
