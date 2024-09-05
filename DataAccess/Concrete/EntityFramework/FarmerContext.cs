using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class FarmerContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=AIR-BT02;Database=FarmerSale;Trusted_Connection=true");
        }
        // Oluşturduğumuz nesneleri ilişkilendiririz mesela order nesnemi orders ile ilşkilendirirm orders ise datadaki adı
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}
