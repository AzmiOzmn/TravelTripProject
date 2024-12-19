using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {

        Context db = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var values = db.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniBlog(Blog model)
        {
            db.Blogs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BlogSil(int id)
        {
            var blog = db.Blogs.Find(id);
            db.Blogs.Remove(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult BlogGuncelle(int id)
        {
            var value = db.Blogs.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult BlogGuncelle(Blog model)
        {
            var value = db.Blogs.Find(model.ID);
            value.Baslik = model.Baslik;
            value.Tarih = model.Tarih;
            value.BlogImage = model.BlogImage;
            value.Aciklama = model.Aciklama;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var values = db.Yorumlars.ToList();
            return View(values);
        }

        public ActionResult YorumSil(int id)
        {
            var values = db.Yorumlars.Find(id);
            db.Yorumlars.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult YorumGuncelle(int id)
        {
            var values = db.Yorumlars.Find(id);
            return View(values);

        }

        [HttpPost]
        public ActionResult YorumGuncelle(Yorumlar model)
        {
            var values = db.Yorumlars.Find(model.ID);
            values.Mail = model.Mail;
            values.Yorum = model.Yorum;
            values.KullaniciAdi = model.KullaniciAdi;
            db.SaveChanges();
            return RedirectToAction("YorumListesi");
        }





    }
}
