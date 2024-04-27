using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vizegorselsinavi22.Models.Entity;
namespace vizegorselsinavi22.Controllers
{
    public class ogretmen1Controller : Controller
    {
        vizegorselsinavEntities1 db = new vizegorselsinavEntities1();
        // GET: ogretmen1
        public ActionResult Index()
        {

            var degerler = db.tbl_ogretmen.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult Yeniogretmen()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeniogretmen(tbl_ogretmen p1)
        {
            db.tbl_ogretmen.Add(p1);
            db.SaveChanges();
            return View();
        }
    }
}