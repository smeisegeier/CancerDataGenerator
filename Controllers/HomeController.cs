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
        }

        public IActionResult Validate()
        {
            ADT_GEKID a = getNewRootObject();
            var xml = Globals.GetXmlStringFromObject(a);
            var messages = Globals.ValidateXml(xml, Globals.XSDNAMESPACE, Globals.XSDPATHRELATIVE);

            return Content(Globals.ValidationMessageItem.PrintItemList(messages));
        }



        private static ADT_GEKID getNewRootObject()
        {
            /* bottom -> up */
            var meld = new Meldung();


            var pat = new Patient();
            pat.Anmerkung = "lol";
            pat.Patienten_Stammdaten = new Patienten_Stammdaten();
//            pat.Patienten_Stammdaten.Patienten_Geburtsdatum = "12.07.1980";
            pat.Patienten_Stammdaten.Patienten_Geburtsdatum = "lol";
            pat.Patienten_Stammdaten.Patienten_Nachname = "Doe";
            pat.Patienten_Stammdaten.Patienten_Vornamen = "John James";

            pat.Menge_Meldung = new List<Meldung>();
            pat.Menge_Meldung.Add(meld);

            var a = new ADT_GEKID();
            a.Menge_Patient = new List<Patient>();
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
