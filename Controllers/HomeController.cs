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

            //return Content("lol");
            return Content(Globals.GetXmlStringFromObject(a));

            //return Json(a);
        }

        public IActionResult Validate()
        {
            ADT_GEKID a = getNewRootObject();
            var serial = Globals.GetXmlStringFromObject(a);

            var xsdPath = "Models/ADT_GEKID_v2.2.1.xsd";
            XDocument xml = XDocument.Parse(serial);
            //xml.Document.Root.SetAttributeValue("xmlns", "http://www.gekid.de/namespace");
            XmlSchemaSet schemaSet = new XmlSchemaSet();
            schemaSet.Add("http://www.gekid.de/namespace", xsdPath);

            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.ValidationFlags |= XmlSchemaValidationFlags.ReportValidationWarnings;
            string message = "";
            xmlReaderSettings.ValidationEventHandler += (o, e) =>
            {
                message += ($"Severity: {e.Severity.ToString()} | Message: {e.Message}\n");
            };
            xmlReaderSettings.Schemas = schemaSet;
            XmlReader xmlReader = XmlReader.Create(xml.CreateReader(), xmlReaderSettings);
            while (xmlReader.Read());

            //// override default (deviant) core behaviour and allow resolving
            //schemaSet.XmlResolver = new XmlUrlResolver();
            //// compile all schemas
            //schemaSet.Compile();

            //xml.Validate(schemaSet, (o, e) =>
            //    {
            //        message += ($"Severity: {e.Severity.ToString()} | Message: {e.Message}");
            //    }
            //);
            return Content(message);

            /*
            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
            xml.Validate(schemaSet, eventHandler);
            return Content("lul");
            */
        }

        //public static void ValidationEventHandler(object sender, ValidationEventArgs e)
        //{
        //    string message = "";
        //    message += ($"Severity: {e.Severity.ToString()} | Message: {e.Message}");
        //}

        private static ADT_GEKID getNewRootObject()
        {
            var a = new ADT_GEKID();
            a.Menge_Patient = new List<Patient>();
            a.Schema_Version = Schema_Version.Item211;
            var pat = new Patient();
            pat.Anmerkung = "lol";
            pat.Patienten_Stammdaten = new Patienten_Stammdaten();
            pat.Patienten_Stammdaten.Patienten_Geburtsdatum = "12.07.1980";
            //pat.Patienten_Stammdaten.Patienten_Nachname = "Doe";
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
