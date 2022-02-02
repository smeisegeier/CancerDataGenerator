using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Rki.CancerDataGenerator.DAL;
using Rki.CancerDataGenerator.Services;

namespace Rki.CancerDataGenerator.Controllers
{
    [ApiController]
    [Route(Globals.ROUTESTRING)]
    public class PublicController : ControllerBase
    {
        public PublicController(IWebHostEnvironment webHostEnvironment, AdtGekidDbContext context, IJwtAuthenticator jwtAuthenticator)
            : base(webHostEnvironment, context, jwtAuthenticator) {}

        /// <summary>
        /// Get token upon username / passwd
        /// </summary>
        /// <param name="userCrendential"></param>
        /// <returns>JWT bearer token</returns>
        [HttpPost()]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult Login([FromBody] UserCrendential userCrendential)
        {
            var token = _jwtAuthenticator.IsUserAuthenticated(userCrendential.Username, userCrendential.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }


        /// <summary>
        /// Returns jwt that is used for authentification. For testing pupose
        /// </summary>
        /// <returns></returns>
        [HttpGet("login/test")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Test()
        {
            var token = Request.Headers[HeaderNames.Authorization].ToString()?.Replace("Bearer ", "");
            var payload = _jwtAuthenticator.DecodeToken(token);
            if (payload is null)
                return BadRequest("jwt is not present");

            return Json(payload);
        }
    }
}
