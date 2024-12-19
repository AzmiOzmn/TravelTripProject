using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Sınıflar;

// TravelTripContext alias'ını tanımlıyoruz
using TravelTripContext = TravelTripProject.Models.Sınıflar.Context;

namespace TravelTripProject.Controllers
{
    public class GirisYapController : Controller
    {
        // Alias kullanarak Context'e erişiyoruz
        TravelTripContext db = new TravelTripContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin az)
        {
            var bilgiler = db.Admins.FirstOrDefault(a => a.Kullanici == az.Kullanici && a.Sifre == az.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.Kullanici, false);
                Session["Kullanici"] = bilgiler.Kullanici.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }
    }
}
