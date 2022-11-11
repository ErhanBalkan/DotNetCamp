using Microsoft.EntityFrameworkCore;
// Context = DB tabloları ile proje classlarını bağlamak
public class NorthwindContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        string connectionString = @"Server=ERHAN-MATEBOOK;Database=Northwind;Trusted_Connection=true";
        optionsBuilder.UseSqlServer(connectionString);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
}