using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class AboutController : Controller
    {
        context c = new context();
        [Authorize]
        public ActionResult AboutList()
        {
            var degerler = c.hakkimizdas.ToList();
            return View(degerler);
        }

        public ActionResult Iletisim()
        {
            var values = c.iletisims.ToList();
            return View(values);
        }

        public ActionResult IletisimSil(int id)
        {
            var ileti = c.iletisims.Find(id);
            c.iletisims.Remove(ileti);
            c.SaveChanges();
            return RedirectToAction("Iletisim","About");
        }
    }
}