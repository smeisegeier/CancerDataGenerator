using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Rki.CancerDataGenerator.DAL;
using Rki.CancerDataGenerator.Services;

namespace Rki.CancerDataGenerator.Controllers
{
    // TODO doc https://docs.microsoft.com/en-us/aspnet/core/web-api/advanced/analyzers?view=aspnetcore-5.0&tabs=visual-studio

    [ApiController]
    [Route(Globals.ROUTESTRING)]
    public class PublicController : ControllerBase
    {
        public PublicController(IWebHostEnvironment webHostEnvironment, AdtGekidDbContext context, IJwtAuthenticator jwtAuthenticator)
            : base(webHostEnvironment, context, jwtAuthenticator) {}

        /// <summary>
        /// GET TOKEN XDE
        /// </summary>
        /// <param name="userCrendential"></param>
        /// <returns>JWT bearer token</returns>
        [HttpPost()]
        public IActionResult Login([FromBody] UserCrendential userCrendential)
        {
            var token = _jwtAuthenticator.IsUserAuthenticated(userCrendential.Username, userCrendential.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }


        [HttpGet("login/test")]
        public IActionResult Test()
        {
            var token = Request.Headers[HeaderNames.Authorization].ToString()?.Replace("Bearer ", "");
            var payload = _jwtAuthenticator.DecodeToken(token);
            if (payload is null)
                return BadRequest("jwt was not provided");

            return Json(payload);
        }
    }
}
