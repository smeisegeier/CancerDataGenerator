﻿using Microsoft.AspNetCore.Mvc;
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
        private readonly Generator _generator;

        public HomeController(ILogger<HomeController> logger, AdtGekidDbContext context)
        {
            _logger = logger;
            _generator = new Generator(context);
        }

        //public IActionResult Index() => Redirect(nameof(Details));
        public IActionResult Index() => View();

        public IActionResult Details()
        {
            ADT_GEKID a = getNewRootObject();
            // also give contentType to trigger browser addons for xml view
            return Content(Globals.GetXmlStringFromObject(a), "application/xml");
        }

        public IActionResult Validate()
        {
            ADT_GEKID a = getNewRootObject();
            var xml = Globals.GetXmlStringFromObject(a);
            var messages = Globals.ValidateXml(xml, Globals.XSDNAMESPACE, Globals.XSDPATHRELATIVE);

            return Content(Globals.ValidationMessageItem.PrintItemList(messages));
        }

        // TODO fetch xml file -> validate
        // TODO make API

        private ADT_GEKID getNewRootObject() => new ADT_GEKID(_generator, null);

        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
