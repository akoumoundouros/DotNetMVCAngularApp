using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public PartialViewResult Q1() => PartialView("~/Views/Home/Templates/Q1.cshtml");
        
        public PartialViewResult Q2() => PartialView("~/Views/Home/Templates/Q2.cshtml");

        public PartialViewResult Q3() => PartialView("~/Views/Home/Templates/Q3.cshtml");

        public PartialViewResult Calc() => PartialView("~/Views/Home/Templates/Calc.cshtml");
    }
}
