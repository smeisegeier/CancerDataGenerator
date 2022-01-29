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
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net.Mime;
using Microsoft.EntityFrameworkCore;
using Rki.CancerDataGenerator.Services;
using Microsoft.AspNetCore.Authorization;
using static Rki.CancerDataGenerator.Services.User;

namespace Rki.CancerDataGenerator.Controllers
{

    /// <summary>
    /// All about locations. Requires login.
    /// </summary>
    [ApiController]
    [Authorize]
    [Route(Globals.ROUTESTRING)]
    public class LocationController : ControllerBase
    {
        public LocationController(IWebHostEnvironment webHostEnvironment, AdtGekidDbContext context, IJwtAuthenticator jwtAuthenticator)
            : base(webHostEnvironment, context, jwtAuthenticator) { }

        /// <summary>
        /// Get all items
        /// </summary>
        /// <remarks>
        /// Here is text
        /// </remarks>
        /// <returns>list</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public List<Location> Get() => _context.GetAll<Location>().ToList();


        /// <summary>
        /// Get all items as download
        /// </summary>
        /// <remarks>
        /// DL the file
        /// </remarks>
        /// <returns>file</returns>
        [HttpGet("download")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetDownload()
        {
            return WriteFileAsJson(_context.GetAll<Location>().ToList());
        }

        /// <summary>
        /// Get item with [id]
        /// </summary>
        /// <returns>item</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            if (id < 1)
                return BadRequest();

            var result = _context.GetById<Location>(id);
            if (result is null)
                return StatusCode(404, "item does not exist");

            return Json(result);
        }

        /// <summary>
        /// Get item with [name]
        /// </summary>
        /// <remarks>
        /// Finds items with names beginning w/ the given string
        /// </remarks>
        /// <returns>item</returns>
        [HttpGet("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByName(string name)
        {
            if (string.IsNullOrEmpty(name))
                return BadRequest();

            var result = _context.GetByName<Location>(name);
            if (result is null)
                return NotFound();

            return Json(result);
        }


        /// <summary>
        /// Creates a location. Requires ADMIN role.
        /// </summary>
        /// <remarks>
        /// Sample request (id can be left 0):
        /// 
        ///     POST /Location
        ///     {
        ///        "id": 0,
        ///        "location_id": "16",
        ///        "location_state": "Mallorca",
        ///        "Weight": "0"
        ///     }
        ///     
        /// </remarks>
        /// <param name="location"></param>
        /// <returns>A newly created location</returns>
        [HttpPost]
        [Authorize(Roles = nameof(UserRole.ADMIN))]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult PostItem([FromBody] Location location)
        {
            if (location is null)
                return BadRequest();

            var itemId = _context.AddItem(location);
            if (itemId == 0)
                return NotFound("returned id has no value");

            return CreatedAtAction(nameof(PostItem), new { id = itemId }, location);
        }

        /// <summary>
        /// Deletes a location. Requires ADMIN role.
        /// </summary>
        /// <remarks>
        /// Delete it
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>204</returns>
        [HttpDelete("{id:int}")]
        [Authorize(Roles = nameof(UserRole.ADMIN))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteItem(int id)
        {
            if (id < 1)
                return BadRequest();

            var itemId = _context.DeleteItem<Location>(id);
            if (itemId == 0)
                return NotFound("returned id has no value");

            return NoContent();
        }

        /// <summary>
        /// Modifies a location.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST /Location
        ///     {
        ///        "id": 11,
        ///        "location_id": "10",
        ///        "location_state": "Saarland neu",
        ///        "Weight": "0"
        ///     }
        ///     
        /// </remarks>
        /// <param name="location"></param>
        /// <returns>204</returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult PutItem([FromBody] Location location)
        {
            if (location is null)
                return BadRequest();

            int id = _context.UpdateItem(location);
            if (id == 0)
                return NotFound();

            return NoContent();
        }

    }
}
