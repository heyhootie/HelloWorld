using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
    
        public ActionResult Index()
        {
            //ViewData["message"] = "Hello, World";
            ViewBag.Message = "Hello Imulus!";
            
            return View();
        }

    }
}
