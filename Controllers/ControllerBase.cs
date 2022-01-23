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

namespace Rki.CancerDataGenerator.Controllers
{
    [ApiController]
    public abstract class ControllerBase : Controller
    {

        protected readonly IWebHostEnvironment _webHostEnvironment;
        protected readonly ILogger<HomeController> _logger;
        protected readonly Generator _generator;
        protected readonly AdtGekidDbContext _context;

        protected string FileDirectory => Path.Combine(_webHostEnvironment.WebRootPath, "files");

        public ControllerBase(IWebHostEnvironment webHostEnvironment, ILogger<HomeController> logger, AdtGekidDbContext context)
        {
            _logger = logger;
            _generator = new Generator(context);
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        protected ADT_GEKID getNewRootObject() => new ADT_GEKID(_generator, null);

    }
}
