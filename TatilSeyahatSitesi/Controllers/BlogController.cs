using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class BlogController : Controller
    {
        context c = new context();
        blogyorum by = new blogyorum();
        [Authorize]
        public ActionResult BlogList()
        {
            //var degerler = c.blogs.ToList();
            by.deger1 = c.blogs.ToList();
            by.deger3 = c.blogs.OrderByDescending(x=>x.blogID).Take(3).ToList();
            return View(by);
        }
        
        public ActionResult BlogDetails(int id)
        {
            //var blogbul = c.blogs.Where(x => x.blogID == id).ToList();//bloğun idsi ile parametreden gelen id aynı ise uyan ilk değeri getir
            by.deger1 = c.blogs.Where(x => x.blogID == id).ToList();
            by.deger2 = c.yorums.Where(x => x.blogID == id).ToList();
            return View(by);
        }

        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult YorumYap(yorum y)
        {
            c.yorums.Add(y);
            c.SaveChanges();
            return PartialView();
        }
        public PartialViewResult PartialSonPost()
        {
            var degerler = c.blogs.OrderByDescending(x => x.blogID).Take(4).ToList();
            return PartialView(degerler);
        }
    }
}