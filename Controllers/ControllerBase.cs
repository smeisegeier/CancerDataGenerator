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
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Web;
using System.Net.Mime;

namespace Rki.CancerDataGenerator.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected IWebHostEnvironment _webHostEnvironment { get; }
        protected readonly ILogger<HomeController> _logger;
        protected Generator _generator { get; set; }
        protected AdtGekidDbContext _context { get; }

        protected string FileDirectory => Path.Combine(_webHostEnvironment.WebRootPath, "files");

        public ControllerBase(IWebHostEnvironment webHostEnvironment, ILogger<HomeController> logger, AdtGekidDbContext context)
        {
            _logger = logger;
            _generator = new Generator(context);
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        protected ADT_GEKID getNewRootObject() => new ADT_GEKID(_generator, null);

        protected IActionResult WriteFileAsJson<T>(IList<T> list) where T : DimensionBase
        {
            string content = Helper.StaticHelper.ToJson(list);

            if (string.IsNullOrEmpty(content))
                return BadRequest();

            string fullPath = Path.Combine(FileDirectory, "download.json");
            System.IO.File.WriteAllText(fullPath, content);
            return ReturnAndDeleteFile(fullPath);
            //return File(await System.IO.File.ReadAllBytesAsync(filePath), "application/octet-stream", fileName);
        }

        protected IActionResult ReturnAndDeleteFile(string fullPath)
        {
            if (!System.IO.File.Exists(fullPath))
                return BadRequest();

            // read bytes
            var bytes = System.IO.File.ReadAllBytes(fullPath);
            // file can be deleted now
            System.IO.File.Delete(fullPath);
            //return file
            return File(bytes, MediaTypeNames.Text.Plain, Path.GetFileName(fullPath));
        }
    }
}
