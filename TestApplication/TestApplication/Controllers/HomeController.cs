using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Yur contact page.";


            return View();
        }

        public ContentResult GetData()
        {
            var data = new
            {
                Id = 1,
                Name = "Sample Data",
                IsActive = true
            };

            string json = JsonConvert.SerializeObject(data);
            return Content(json, "application/json");
        }
    }
}