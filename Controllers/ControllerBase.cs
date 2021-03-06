using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rki.CancerDataModel.Models;
using Rki.CancerDataModel.Models.Dimensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Rki.CancerDataGenerator.DAL;
using Rki.CancerDataModel.Models.ADTGEKID;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Web;
using System.Net.Mime;
using Rki.CancerDataGenerator.Services;
using Rki.CancerDataGenerator.BLL;

namespace Rki.CancerDataGenerator.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected IWebHostEnvironment _webHostEnvironment { get; }

        protected AdtGekidDbContext _context { get; }

        protected Generator _generator { get; set; }

        protected ADT_GEKID _adtgekid => new Modelbuilder(_generator).ADT_GEKID;

        protected IJwtAuthenticator _jwtAuthenticator { get; }
        protected string FileDirectory => Path.Combine(_webHostEnvironment.WebRootPath, "files");

        public ControllerBase(IWebHostEnvironment webHostEnvironment, AdtGekidDbContext context, IJwtAuthenticator jwtAuthenticator)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _jwtAuthenticator = jwtAuthenticator;
            _generator = new Generator(_context);
        }


        protected IActionResult WriteFileAsJson<T>(IList<T> list) where T : DimensionBase
        {
            string content = StaticHelper.Xml.ToJson(list);

            if (string.IsNullOrEmpty(content))
                return BadRequest();

            string fullPath = Path.Combine(FileDirectory, "download.json");
            System.IO.File.WriteAllText(fullPath, content);
            return ReturnAndDeleteFile(fullPath);
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
