using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;




namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            var degerler = db.Blogs.ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
    }
}