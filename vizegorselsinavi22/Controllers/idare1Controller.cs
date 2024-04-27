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
            
            var degerler = db.tbl_idari.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Yeniyonetici()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeniyonetici(tbl_idari p1)
        {
            db.tbl_idari.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult Sil(int id)
        {
            var idari = db.tbl_idari.Find(id);
            db.tbl_idari.Remove(idari);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult yoneticiguncelle(int id)
        {
            var yonetici = db.tbl_idari.Find(id);
            return View("yoneticiguncelle", yonetici);
        }
        public ActionResult Guncelle(tbl_idari p1)
        {
            var idare = db.tbl_idari.Find(p1.idariid);
            idare.idariAdSoyad = p1.idariAdSoyad;
            idare.idariUnvan = p1.idariUnvan;
            idare.idariBasla = p1.idariBasla;
            idare.idariCikis = p1.idariCikis;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}