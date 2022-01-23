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
    [Route("api/[controller]")]
    public class IcdController : Controller
    {
        protected readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<HomeController> _logger;
        private readonly Generator _generator;
        private readonly AdtGekidDbContext _context;

        protected string FileDirectory => Path.Combine(_webHostEnvironment.WebRootPath, "files");

        public IcdController(IWebHostEnvironment webHostEnvironment, ILogger<HomeController> logger, AdtGekidDbContext context)
        {
            _logger = logger;
            _generator = new Generator(context);
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        // TODO create controllerbase
        [HttpGet]
        [ProducesResponseType(typeof(byte[]), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            string content = Helper.StaticHelper.ToJson(_context.GetAll<Location>());
            //string path = Path.Combine(FileDirectory, $"{typeof(T).Name}_List.json");
            string path = Path.Combine(FileDirectory, "temp.json");
            System.IO.File.WriteAllText(path, content);
            return ReturnAndDeleteFile(path);

            //var filePath = $"files/{fileName}"; // get file full path based on file name
            //if (!System.IO.File.Exists(filePath))
            //{
            //    return BadRequest();
            //}
            //return File(await System.IO.File.ReadAllBytesAsync(filePath), "application/octet-stream", fileName);
        }

        protected IActionResult ReturnAndDeleteFile(string path)
        {
            if (!System.IO.File.Exists(path))
            {
                return BadRequest();
            }

            // read bytes
            var bytes = System.IO.File.ReadAllBytes(path);
            // file can be deleted now
            System.IO.File.Delete(path);
            //return file
            return File(bytes, MediaTypeNames.Text.Plain, Path.GetFileName(path));
        }

        /// <summary>
        /// Get items with [id]
        /// </summary>
        /// <returns>item</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Get(int id)
        {
            var result = _context.GetById<Icd>(id);
            if (result is null)
                return StatusCode(404, "item does not exist");
            return Json(result);
        }


    }
}
