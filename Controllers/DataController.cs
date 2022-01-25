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
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;

/// <summary>
/// https://stackoverflow.com/questions/60084877/swagger-not-finding-apiversion-ed-actions
/// </summary>
namespace Rki.CancerDataGenerator.Controllers
{
    //[Authorize]
    [ApiController]
    [ApiVersion("1")]
    [ApiVersion("2")]
    [Route("/api/v{version:apiVersion}/[controller]")]
    public class DataController : ControllerBase
    {
        public DataController(IWebHostEnvironment webHostEnvironment, ILogger<HomeController> logger, AdtGekidDbContext context)
            : base(webHostEnvironment, logger, context) { }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("1")]
        [Produces("application/xml")]
        public IActionResult GetAllData()
        {
            ADT_GEKID a = getNewRootObject();
            // also give contentType to trigger browser addons for xml view
            return Content(Globals.GetXmlStringFromObject(a), "application/xml");
        }

        /// <summary>
        /// xDE
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("2")]
        [Produces("application/xml")]
        public IActionResult GetAllDatav2() => Content("lol");

    }



}



