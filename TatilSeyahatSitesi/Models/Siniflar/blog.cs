using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class blog
    {
        [Key]
        public int blogID { get; set; }
        public string baslik { get; set; }
        public DateTime tarih { get; set; }
        public string baciklama { get; set; }
        public string blogImage { get; set; }
        public ICollection <yorum> yorums { get; set; }// bloqa birden fazla yorum yapılacağı için ıcollection verdik
    }
}