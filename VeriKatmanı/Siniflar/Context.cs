using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriKatmanı.Siniflar
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DESKTOP-6B81MV8; database=gidesimgeldiDB;integrated security=true;");
        }

        public DbSet<Bulten> Bultens { get; set; }
        public DbSet<Destinasyon> Destinasyons { get; set; }
        public DbSet<Hakkinda> Hakkindas { get; set; }
        public DbSet<Hakkinda2> Hakkinda2s { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<OneCikanlar> OneCikanlars { get; set; }
        public DbSet<OneCikanlar2> OneCikanlar2s { get; set; }
        public DbSet<Referans> Referanses { get; set; }
        public DbSet<Rehber> Rehbers { get; set; }
        public DbSet<Sub_Hakkinda> Sub_Hakkindas { get; set; }
    }
}
