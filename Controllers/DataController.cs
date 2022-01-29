using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Rki.CancerDataGenerator.BLL;
using Rki.CancerDataGenerator.DAL;
using Rki.CancerDataGenerator.Models.ADTGEKID;
using Rki.CancerDataGenerator.Services;
using static Rki.CancerDataGenerator.Services.User;

/// <summary>
/// https://stackoverflow.com/questions/60084877/swagger-not-finding-apiversion-ed-actions
/// </summary>
namespace Rki.CancerDataGenerator.Controllers
{
    //TODO login controller

    [ApiController]
    [ApiVersion("1")]
    [ApiVersion("2")]
    [Route("/api/v{version:apiVersion}/[controller]")]
    public class DataController : ControllerBase
    {
        private IJwtAuthenticator _jwtAuthenticator { get; }
        public DataController(IWebHostEnvironment webHostEnvironment, ILogger<HomeController> logger, AdtGekidDbContext context
            , IJwtAuthenticator jwtAuthenticator)
            : base(webHostEnvironment, logger, context)
        {
            _jwtAuthenticator = jwtAuthenticator;
        }

        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = nameof(UserRole.DEV))]
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


            _generator.Configuration = configuration;
            ADT_GEKID a = getNewRootObject();
            // also give contentType to trigger browser addons for xml view
            return Content(Globals.GetXmlStringFromObject(a), "application/xml");

        }


        /// <summary>
        /// GET TOKEN XDE
        /// </summary>
        /// <param name="userCrendential"></param>
        /// <returns>JWT bearer token</returns>
        [HttpPost("auth")]
        public IActionResult Authenticate([FromBody] UserCrendential userCrendential)
        {
            var token = _jwtAuthenticator.IsUserAuthenticated(userCrendential.Username, userCrendential.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }


        // TODO fix exception
        [HttpGet("test")]
        public IActionResult Test()
        {
            var token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var lol = _jwtAuthenticator.DecodeToken(token);
            return Ok(lol.sub);
        }
    }



}



