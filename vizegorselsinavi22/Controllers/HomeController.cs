using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vizegorselsinavi22.Models.Entity;
namespace vizegorselsinavi22.Controllers
{
    public class HomeController : Controller
    {
        vizegorselsinavEntities1 db = new vizegorselsinavEntities1();
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
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}