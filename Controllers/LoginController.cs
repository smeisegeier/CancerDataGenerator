using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using Rki.CancerDataGenerator.DAL;
using Rki.CancerDataGenerator.Services;

namespace Rki.CancerDataGenerator.Controllers
{

    [ApiController]
    [Route(Globals.ROUTESTRING)]
    public class LoginController : ControllerBase
    {
        public LoginController(IWebHostEnvironment webHostEnvironment, AdtGekidDbContext context, IJwtAuthenticator jwtAuthenticator)
            : base(webHostEnvironment, context, jwtAuthenticator) {}

        /// <summary>
        /// GET TOKEN XDE
        /// </summary>
        /// <param name="userCrendential"></param>
        /// <returns>JWT bearer token</returns>
        [HttpPost()]
        public IActionResult Authenticate([FromBody] UserCrendential userCrendential)
        {
            var token = _jwtAuthenticator.IsUserAuthenticated(userCrendential.Username, userCrendential.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }


        [HttpGet("test")]
        public IActionResult Test()
        {
            var token = Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
            var lol = _jwtAuthenticator.DecodeToken(token);
            return Ok(lol.sub);
        }
    }
}
