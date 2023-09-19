using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class ContactController : Controller
    {
        context c = new context();
        public ActionResult ContactList(iletisim i)
        {
            ViewBag.adres = c.contacts.Select(x => x.konum).FirstOrDefault();
            ViewBag.telefon = c.contacts.Select(x => x.tel).FirstOrDefault();
            ViewBag.haritakonum = c.contacts.Select(x => x.harita).FirstOrDefault();
            c.iletisims.Add(i);
            c.SaveChanges();
            return View();
        }
        
    }
}