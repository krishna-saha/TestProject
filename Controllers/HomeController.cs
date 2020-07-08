using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using TestProject.Models;

namespace TestProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            WebClient client = new WebClient();
            var jsonData = client.DownloadString("https://od-do.agr.gc.ca/canadianCheeseDirectory.json");
            var cheeses = JsonConvert.DeserializeObject<Cheeses>(jsonData);
            return View(cheeses);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}