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
            var degerler = db.Blogs.Take(4).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var partial1 = db.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();    
            return PartialView(partial1);
        }
        public PartialViewResult Partial2()
        {
            var partial2 = db.Blogs.Where(x => x.ID==1).ToList();
            return PartialView(partial2);
        }
        public PartialViewResult Partial3()
        {
            var partial3 = db.Blogs.ToList();
            return PartialView(partial3); 
        }

        public PartialViewResult Partial4()
        {
            var partial4 = db.Blogs.Take(3).ToList();
            return PartialView(partial4);
        }

        public PartialViewResult Partial5()
        {
            var partial5 = db.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return PartialView(partial5);
        }
    }
}