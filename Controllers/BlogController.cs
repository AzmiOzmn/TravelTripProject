using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;


namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        Context db = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            //var bloglar = db.Blogs.ToList();
            by.Deger1 = db.Blogs.ToList();
            by.Deger3 = db.Blogs
     .OrderByDescending(b => b.Tarih)
     .Take(3) 
     .ToList();

            return View(by);
        }   
        public ActionResult BlogDetay(int id) 
        {
            by.Deger1 = db.Blogs.Where(x=> x.ID == id).ToList();
            by.Deger2 = db.Yorumlars.Where(x=> x.Blogid == id).ToList();
            return View(by);
        }
    }
}