using Microsoft.EntityFrameworkCore;
using ProductManagementWebApi.Models;

namespace ProductManagementWebApi.Models
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=DESKTOP-29OOQRI;initial catalog=PMWADb;user id=yasin;password=123456789;TrustServerCertificate=True;");
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}
