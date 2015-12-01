using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogRepo.Factories;
using BlogRepo.Models.BaseModels;

namespace MVC_Test.Controllers
{
    public class HomeController : Controller
    {
        

        // GET: Home
        public ActionResult Index()
        {
            
            return View();
        }
    }
}