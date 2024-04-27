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
        public ActionResult Sil(int id)
        {
            var ogretmen = db.tbl_ogretmen.Find(id);
            db.tbl_ogretmen.Remove(ogretmen);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ogretmenguncelle(int id)
        {
            var ogrtgun = db.tbl_ogretmen.Find(id);
            return View("ogretmenguncelle", ogrtgun);
        }
        public ActionResult Guncelle(tbl_ogretmen p1)
        {
            var musteri = db.tbl_ogretmen.Find(p1.ogretmenid);
            musteri.ogretmenAd = p1.ogretmenAd;
            musteri.ogretmenSoyad = p1.ogretmenSoyad;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}