using Microsoft.EntityFrameworkCore;

namespace MVCdbConnect.Models.ORM
{

    public class SiemensContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost\\SQLEXPRESS; Database =MVC ; Trusted_Connection = True;");
        }

        public DbSet<Suppliers> Suppliers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

    }
}
