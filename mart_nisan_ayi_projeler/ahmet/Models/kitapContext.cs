using Microsoft.EntityFrameworkCore;

namespace urun.Models
{
    public class kitapContext : DbContext
    {
        public kitapContext() { }
        public kitapContext(DbContextOptions<kitapContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./wwwroot/kitap.db");
        }

        public DbSet<Kitaplar> kitaplistesi { get; set; }
    }
}
