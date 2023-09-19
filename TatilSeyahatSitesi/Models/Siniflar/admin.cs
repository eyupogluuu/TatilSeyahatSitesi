using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class admin
    {
        [Key]
        public int adminID { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
    }
}