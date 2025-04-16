using Microsoft.EntityFrameworkCore;

namespace veriatl.Models
{
    public class ogrenciContext : DbContext
    {
        public ogrenciContext() { }
        public ogrenciContext(DbContextOptions<ogrenciContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=OgrenciDB.db");
        }

        public DbSet<Ogrenci> ogrenciler { get; set; }
    }
}