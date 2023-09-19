using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class hakkimizda
    {
        [Key]
        public int hakID { get; set; }
        public string hgorselUrl { get; set; }
        public string haciklama { get; set; }
    }
}