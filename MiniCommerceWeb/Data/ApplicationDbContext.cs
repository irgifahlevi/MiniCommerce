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

        // Just for send migration data
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //   modelBuilder.Entity<Category>().HasData(
        //       new Category { 
        //           ID = 0, 
        //           Name = "NULL",
        //           DisplayOrder = 0, 
        //           CreatedBy = "MIGRATION", 
        //           CreatedAt = "NULL", 
        //           UpdatedAt = "NULL", 
        //           RowStatus = -1 
        //       });
        //}
    }
}
