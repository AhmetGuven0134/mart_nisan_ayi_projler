using Microsoft.EntityFrameworkCore;

namespace kitap.Models
{
    public class KitapContext : DbContext
    {
        public KitapContext() { }
        public KitapContext(DbContextOptions<KitapContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./wwwroot/urun.db");
        }

        public DbSet<Kitaplar> kitaplistesi { get; set; }
    }
}
