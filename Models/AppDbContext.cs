using Microsoft.EntityFrameworkCore;

namespace mvc1.Models {
    public class AppDbContext : DbContext {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base (options) {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}