using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataGenerator.DAL;
using Rki.CancerDataGenerator.Services;
using Rki.CancerDataGenerator.StaticHelper;


namespace Rki.CancerDataGenerator.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [ApiVersion("2")]
    [Route(Globals.ROUTESTRING)]
    public class DataController : ControllerBase
    {
        public DataController(IWebHostEnvironment webHostEnvironment, AdtGekidDbContext context, IJwtAuthenticator jwtAuthenticator)
            : base(webHostEnvironment, context, jwtAuthenticator) { }

        /// <summary>
        /// Get all data as xml
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [MapToApiVersion("1")]
        [Produces("application/xml")]
        public IActionResult GetAllData()
        {
            //ADT_GEKID a = getNewRootObject();
            // also give contentType to trigger browser addons for xml view
            return base.Content(StaticHelper.Xml.GetXmlStringFromObject(_adtgekid), "application/xml");

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
        /// Get all data based upon the configuration you post
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


            _generator.Configuration = configuration;
            // also give contentType to trigger browser addons for xml view
            return base.Content(StaticHelper.Xml.GetXmlStringFromObject(_adtgekid), "application/xml");
        }

        /// <summary>
        /// Test to encrypt POST data
        /// </summary>
        /// <param name="input">string must be enclosed w/ ""</param>
        /// <returns>encrypted input</returns>
        [HttpPost("submit")]
        [Consumes("application/json")]
        [Produces("plain/text")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult SubmitEncrypted([FromBody] string input)
        {
            if (input is null)
                return BadRequest();
            string result = Encryption.EncryptString(input, Globals.PUBLICKEY);
            // also give contentType to trigger browser addons for xml view
            return Content(result);
        }


    }

}



