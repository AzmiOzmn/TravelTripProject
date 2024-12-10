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
        public ActionResult Index()
        {
            var bloglar = db.Blogs.ToList();
            return View(bloglar);
        }

        public ActionResult BlogDetay(int id) 
        {
            return View();
        }
    }
}