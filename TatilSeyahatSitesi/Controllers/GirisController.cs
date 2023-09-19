using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class GirisController : Controller
    {
        context c = new context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(admin a)
        {
            var giriskontrol = c.admins.FirstOrDefault(x => x.kullaniciAdi == a.kullaniciAdi && x.sifre == a.sifre);
            if (giriskontrol!=null)
            {
                FormsAuthentication.SetAuthCookie(giriskontrol.kullaniciAdi, false);
                Session["username"] = giriskontrol.kullaniciAdi.ToString();
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
            return RedirectToAction("Login","Giris");
        }
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(admin a)
        {
            c.admins.Add(a);
            c.SaveChanges();
            return RedirectToAction("Login", "Giris");

        }


    }
}