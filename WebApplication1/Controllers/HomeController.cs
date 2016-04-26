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

        public PartialViewResult Q1()
        {
            return PartialView();
        }

        public PartialViewResult Q2()
        {
            return PartialView();
        }

        public PartialViewResult Q3()
        {
            return PartialView();
        }

        public PartialViewResult Calc()
        {
            return PartialView();
        }
    }
}
