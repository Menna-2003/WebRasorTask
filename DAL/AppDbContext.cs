using Microsoft.EntityFrameworkCore;
using WebRasorTask.Models;

namespace WebRasorTask.DAL {
    public class AppDbContext : DbContext {
        public AppDbContext ( DbContextOptions options ) : base( options ) {
        }
        public virtual DbSet<Product> Products {
            get; set;
        }
    }
}
