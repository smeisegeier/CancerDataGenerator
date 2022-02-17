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
using Microsoft.AspNetCore.Hosting;
using JWT.Algorithms;
using JWT;
using JWT.Serializers;
using JWT.Builder;
using Rki.CancerDataGenerator.Services;
using Rki.CancerDataGenerator.Helper;

namespace Rki.CancerDataGenerator.Controllers
{
    public class HomeController : ControllerBase
    {

        public HomeController(IWebHostEnvironment webHostEnvironment, AdtGekidDbContext context, IJwtAuthenticator jwtAuthenticator)
            : base(webHostEnvironment, context, jwtAuthenticator) { }


        [HttpGet]
        public IActionResult Index() => RedirectToAction(nameof(Details));

        [HttpGet]
        public IActionResult Details()
        {
            // also give contentType to trigger browser addons for xml view
            return Content(StaticHelper.GetXmlStringFromObject(_adtgekid), "application/xml");
        }

        [HttpGet]
        public IActionResult Validate()
        {
            var xml = StaticHelper.GetXmlStringFromObject(_adtgekid);
            var messages = StaticHelper.ValidateXml(xml, Globals.XSDNAMESPACE, Globals.XSDPATHRELATIVE);

            return Content(StaticHelper.ValidationMessageItem.PrintItemList(messages));
        }


        [HttpGet]
        public IActionResult Privacy() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true), HttpGet]
        public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

        [HttpGet]
        public IActionResult Test()
        {
            string s = "";
            for (int i = 1; i <= 1000; i++)
            {
                s += _generator.CreateNormalValueUponRange(1, 100) + Environment.NewLine;
            }

            return Content(s, "text/plain");
        }

        [HttpGet]
        public IActionResult Jwt()
        {
            var token = JwtBuilder.Create()
                                  .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
                                  .WithSecret("secret")
                                  .AddClaim("iat", DateTimeOffset.UtcNow.ToUnixTimeSeconds())
                                  .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                                  .AddClaim("iss", "dexterDSD")
                                  .AddClaim("sub", "client")
                                  .Encode();
            return Content(token);
        }


    }
}
