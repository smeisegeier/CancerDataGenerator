using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using Rki.CancerDataGenerator.DAL;
using Microsoft.AspNetCore.Hosting;
using JWT.Algorithms;
using JWT.Builder;
using Rki.CancerDataGenerator.Services;
using Rki.CancerDataGenerator.StaticHelper;

namespace Rki.CancerDataGenerator.Controllers
{
    public class HomeController : ControllerBase
    {

        public HomeController(IWebHostEnvironment webHostEnvironment, AdtGekidDbContext context, IJwtAuthenticator jwtAuthenticator)
            : base(webHostEnvironment, context, jwtAuthenticator) { }


        [HttpGet]
        public IActionResult Index() => View(); //RedirectToAction(nameof(Details));

        [HttpGet]
        public IActionResult Details()
        {
            // also give contentType to trigger browser addons for xml view
            return base.Content(Xml.GetXmlStringFromObject(_adtgekid), "application/xml");
        }

        [HttpGet]
        public IActionResult Validate()
        {
            var xml = Xml.GetXmlStringFromObject(_adtgekid);
            var messages = Xml.ValidateXml(xml, Globals.XSDNAMESPACE, Globals.XSDPATHRELATIVE);

            return base.Content(Xml.ValidationMessageItem.PrintItemList(messages));
        }


        [HttpGet]
        public IActionResult Privacy() => View();

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true), HttpGet]
        //public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

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

        [HttpGet]
        public IActionResult DetailsCrypted()
        {
            return Content(Encryption.EncryptString(Xml.GetXmlStringFromObject(_adtgekid), Globals.PUBLICKEY));
        }

        [HttpGet]
        public IActionResult DetailsSigned() => 
            Content(Encryption.SignString("hi there"));
    }
}
