using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vizegorselsinavi22.Models.Entity;

namespace vizegorselsinavi22.Controllers
{
    public class rapor1Controller : Controller
    {
        vizegorselsinavEntities1 db = new vizegorselsinavEntities1 ();
        // GET: rapor1
        public ActionResult Index()
        {
            var degerler = db.tbl_ogrenciler.ToList();
            return View(degerler);
        }
    }
}