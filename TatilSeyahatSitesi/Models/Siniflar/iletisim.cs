using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class iletisim
    {
        [Key]
        public int iletisimID { get; set; }
        public string adSoyad { get; set; }
        public string mail { get; set; }
        public string konu { get; set; }
        public string mesaj { get; set; }
    }
}