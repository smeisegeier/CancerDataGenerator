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
using DextersLabor;

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

        public IActionResult Index()
        {
            return RedirectToAction(nameof(Details));
        }

        public IActionResult Details()
        {
            var a = new ADT_GEKID();
            a.Menge_Patient = new List<Patient>();
            a.Schema_Version = Schema_Version.Item221;
            var pat = new Patient();
            pat.Anmerkung = "lol";

            var meld = new Meldung();
            pat.Menge_Meldung = new List<Meldung>();
            pat.Menge_Meldung.Add(meld);
            a.Menge_Patient.Add(pat);


            return Content(SerializeHelper.GetXmlStringFromObject(a, "AdtGekid"));

            //return Json(a);
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
