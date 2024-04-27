using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vizegorselsinavi22.Models.Entity;

namespace vizegorselsinavi22.Controllers
{
    public class idare1Controller : Controller
    {
        vizegorselsinavEntities1 db = new vizegorselsinavEntities1 ();
        // GET: idare1
        public ActionResult Index()
        {
            vizegorselsinavEntities1 db = new vizegorselsinavEntities1();
            var degerler = db.tbl_idari.ToList();
            return View(degerler);
        }
    }
}