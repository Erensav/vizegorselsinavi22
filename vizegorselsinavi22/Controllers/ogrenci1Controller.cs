using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vizegorselsinavi22.Models.Entity;
namespace vizegorselsinavi22.Controllers
{
    public class ogrenci1Controller : Controller
    {
        vizegorselsinavEntities1 db = new vizegorselsinavEntities1();
        // GET: ogrenci1
        public ActionResult Index()
        {            

            var degerler = db.tbl_ogrenciler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Yeniogrenci()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Yeniogrenci(tbl_ogrenciler p1)
        {
            db.tbl_ogrenciler.Add(p1);
            db.SaveChanges();
            return View();  
        }
        public ActionResult Sil(int id)
        {
            var ogrenci = db.tbl_ogrenciler.Find(id);
            db.tbl_ogrenciler.Remove(ogrenci);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ogrenciguncellle(int id)
        {
            var ogrnci = db.tbl_ogrenciler.Find(id);
            return View("ogrenciguncellle", ogrnci);
        }
        public ActionResult Guncelle(tbl_ogrenciler p1)
        {
            var ogren = db.tbl_ogrenciler.Find(p1.ogrenciid);
            ogren.ogrenciAdSoyadi = p1.ogrenciAdSoyadi;
            ogren.ogrenciNo = p1.ogrenciNo;
            ogren.ogrencimail = p1.ogrencimail;

            // Dropdown seçimlerinden gelen değerleri işleme
            var secilenBolum = Request["ogrencibolum"];
            var secilenMezunDurumu = Request["ogrenciMezun"];

            // Mezuniyet durumu güncellemeden önce kredi kontrolü
            if (secilenMezunDurumu == "Mezun")
            {
                // Öğrencinin toplam kredisi
                int ogrenciToplamKredi = (int)ogren.ogrenciKredi;

                // Gerekli kredi miktarından küçükse hata mesajı göster
                if (ogrenciToplamKredi < 50)
                {
                    ViewBag.ErrorMessage = "Öğrencinin kredi miktarı mezuniyet için yeterli değil. Lütfen kredi değerini kontrol edin.";
                    return View(p1);
                }
            }

            
            ogren.ogrencibolum = secilenBolum;
            ogren.ogrenciMezun = secilenMezunDurumu == "Mezun" ? true : false;

            db.SaveChanges();
            return RedirectToAction("Index");
        }
        


    }
}