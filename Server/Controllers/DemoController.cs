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
            //// Example JSON
            //var json = "{\"books\":[{\"title\":\"Book 1\", \"author\":\"Author1\", \"price\":762, \"inStock\":15},{\"title\":\"Book 2\", \"author\":\"Author2\", \"price\":100, \"inStock\":1},{\"title\":\"Book 3\", \"author\":\"Author3\", \"price\":185.5, \"inStock\":5},{\"title\":\"Book 4\", \"author\":\"Author 4\", \"price\":1748, \"inStock\":3},{\"title\":\"Book 5\", \"author\":\"Author 5\", \"price\":999, \"inStock\":20},{\"title\":\"Book 6\", \"author\":\"Author 6\", \"price\":499.5, \"inStock\":3},{\"title\":\"Book 7\", \"author\":\"Author 7\", \"price\":564.5, \"inStock\":0}]}";
            //var books = JsonConvert.DeserializeObject<Books>(json);
            //return View(books);

            return View();
      

        //var json = "{[{\"Name\":\"Damla\",\"User Name\":\"admin\",\"Password\":\"admin\",\"Email\":\"admin\"},{\"Name\":\"Lale\",\"User Name\":\"user1\",\"Password\":\"0246\",\"Email\":\"hotmail\"},{\"Name\":\"Mehmet\",\"User Name\":\"user2\",\"Password\":\"1357\",\"Email\":\"gmail\"}]}";

    }
    }
}
