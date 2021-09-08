using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SparseDemo.Shared;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System.Net.Http;
using System.Net.Http.Json;

namespace SparseDemo.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : Controller
    {

        private readonly ILogger<DemoController> logger;

        public DemoController(ILogger<DemoController> logger)
        {
            this.logger = logger;
        }

       [HttpGet]

        public ActionResult Index()
        {
            return View();
        }
    }
}
