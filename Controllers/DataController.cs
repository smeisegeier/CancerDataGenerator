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
using Rki.CancerDataGenerator.BLL;

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


        /// <summary>
        /// Get synthetic data based upon the configuration you post
        /// </summary>
        /// <remarks>
        /// Sample request
        /// 
        ///     POST /Configuration
        ///     {
        ///         "patient_Count": 3,
        ///         "patient_MeanAge": 50,
        ///         "text_ProbMissing": 0.8,
        ///         "icdVersion_ProbMissing": 0.5,
        ///         "icd_ProbMissing": 0.1,
        ///         "dsich_ProbMissing": 0.3,
        ///         "meldedatum_BaseDate": "2010-01-01T15:52:45.339Z",
        ///         "meldedatum_DaysRange": 3650
        ///     }
        ///     
        /// </remarks>
        /// <param name="configuration"></param>
        /// <returns>Synthetic data</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult PostItem([FromBody] Configuration configuration)
        {
            if (configuration is null)
                return BadRequest();

            _generator.Config = configuration;
            //return CreatedAtAction(nameof(PostItem), configuration);
            ADT_GEKID a = getNewRootObject();
            // also give contentType to trigger browser addons for xml view
            return Content(Globals.GetXmlStringFromObject(a), "application/xml");
        }

        // TODO JWT!
    }



}



