using Microsoft.EntityFrameworkCore;
using urun.Models;

namespace veriatl.Models
{
    public class urunContext : DbContext
    {
        public urunContext() { }
        public urunContext(DbContextOptions<urunContext> options) : 
        base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./wwwroot/UrunDB.db");
        }

        public DbSet<urunler> urunlerListesi { get; set; }
    }
}