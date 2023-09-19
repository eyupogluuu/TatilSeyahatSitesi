﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class adresblog
    {
        [Key]
        public int adresID { get; set; }
        public string baslik { get; set; }
        public string aciklama { get; set; }
        public string acikadres { get; set; }
        public string mail { get; set; }
        public string telefon { get; set; }
        public string konum { get; set; }
    }
}