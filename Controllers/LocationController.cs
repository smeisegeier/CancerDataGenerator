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

namespace Rki.CancerDataGenerator.Controllers
{

    [ApiController]
    [ApiVersionNeutral]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        public LocationController(IWebHostEnvironment webHostEnvironment, ILogger<HomeController> logger, AdtGekidDbContext context)
            : base(webHostEnvironment, logger, context) { }

        /// <summary>
        /// Get all items
        /// </summary>
        /// <remarks>
        /// Here is text
        /// </remarks>
        /// <returns>list</returns>
        [HttpGet]
        [ProducesResponseType(typeof(byte[]), StatusCodes.Status200OK)]
        public List<Location> Get() => _context.GetAll<Location>().ToList();


        /// <summary>
        /// Get all items as download
        /// </summary>
        /// <returns>file</returns>
        [HttpGet]
        [Route("download")]
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
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            var result = _context.GetById<Location>(id);
            if (result is null)
                return StatusCode(404, "item does not exist");
            return Json(result);
        }

        /// <summary>
        /// Get item with [name]
        /// </summary>
        /// <returns>item</returns>
        [HttpGet]
        [Route("{name}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByName(string name)
        {
            var result = _context.GetLocations(name);
            if (result is null)
                return StatusCode(404, "item does not exist");
            return Json(result);
        }

        // TODO make qry case invariant
    }
}
