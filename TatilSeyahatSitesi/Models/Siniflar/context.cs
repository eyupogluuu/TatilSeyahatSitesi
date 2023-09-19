using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TatilSeyahatSitesi.Models.Siniflar
{
    public class context : DbContext
    {
        public DbSet<admin> admins  { get; set; }
        public DbSet<adresblog> adresblogs  { get; set; }
        public DbSet<blog> blogs  { get; set; }
        public DbSet<iletisim> iletisims { get; set; }
        public DbSet<hakkimizda> hakkimizdas  { get; set; }
        public DbSet<yorum> yorums  { get; set; }
        public DbSet<contact> contacts  { get; set; }
    }
}