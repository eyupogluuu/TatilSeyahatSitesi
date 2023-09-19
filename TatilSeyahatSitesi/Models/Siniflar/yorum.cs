using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class yorum
    {
        [Key]
        public int yorumID { get; set; }
        public string kullaniciAdi { get; set; }
        public string mail { get; set; }
        public string icerik { get; set; }
        public int blogID { get; set; }
        public virtual blog blog { get; set; }// blog sınıfından blog adında bir değerle yorumun hangi bloğa yapılacağı ilişkisini kurduk
    }
}