using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatSitesi.Models.Siniflar;

namespace TatilSeyahatSitesi.Controllers
{
    public class AdminController : Controller
    {
        context c = new context();
        public ActionResult Index()
        {
            var degerler = c.blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBlog(blog b)
        {
            c.blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var deger = c.blogs.Find(id);
            c.blogs.Remove(deger);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var deger = c.blogs.Find(id);
            return View(deger);
        }
        [HttpPost]
        public ActionResult UpdateBlog(blog b)
        {
            var deger = c.blogs.Find(b.blogID);
            deger.baslik = b.baslik;
            deger.tarih = b.tarih;
            deger.baciklama = b.baciklama;
            deger.blogImage = b.blogImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumList()
        {
            var yorumlar = c.yorums.ToList();
            return View(yorumlar);
        }
        public ActionResult DeleteYorum(int id)
        {
            var yorum = c.yorums.Find(id);
            c.yorums.Remove(yorum);
            c.SaveChanges();
            return RedirectToAction("YorumList");
        }
        [HttpGet]
        public ActionResult UpdateYorum(int id)
        {
            var yorum = c.yorums.Find(id);
            return View(yorum);
        }
        [HttpPost]
        public ActionResult UpdateYorum(yorum y)
        {
            var deger = c.yorums.Find(y.yorumID);
            deger.kullaniciAdi = y.kullaniciAdi;
            deger.mail = y.mail;
            deger.icerik = y.icerik;
            c.SaveChanges();
            return RedirectToAction("YorumList");
        }
    }
}