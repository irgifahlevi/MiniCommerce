using Microsoft.EntityFrameworkCore;
using MiniCommerceWeb.Models;

namespace MiniCommerceWeb.Data
{
    public class ApplicationDbContext : DbContext   
    {
        // options konfigurasi untuk objek DBContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
