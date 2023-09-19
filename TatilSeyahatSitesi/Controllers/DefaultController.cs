using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class DefaultController : Controller
    {
        context c = new context();
        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.blogs.OrderByDescending(x=>x.blogID).ToList();
            return View(degerler);
        }

        public ActionResult About()
        {

            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.blogs.OrderByDescending(x=>x.blogID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = c.blogs.Where(x => x.blogID==1).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial3()
        {
            var degerler = c.blogs.Take(10).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial4()
        {
            var degerler = c.blogs.Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial5()
        {
            var degerler = c.blogs.Take(3).OrderByDescending(x=>x.blogID).ToList();
            return PartialView(degerler);
        }
    }
}