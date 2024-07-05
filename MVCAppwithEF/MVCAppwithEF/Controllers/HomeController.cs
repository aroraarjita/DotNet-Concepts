using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppwithEF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            ViewBag.CountriesList = new List<string>()
            {
                "India",
                "UK",
                "US",
                "Canada"
            };

            ViewData["Countries"] = new List<string>()
            {
                "India",
                "US",
                "UK",
                "Canada"
            };

            return View();
            

        }

        public string GetDetails()
        {
            return "GetDetails Invoked";
        }

    }
}