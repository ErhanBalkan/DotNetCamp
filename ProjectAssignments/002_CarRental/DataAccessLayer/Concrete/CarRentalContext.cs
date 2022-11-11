using Microsoft.EntityFrameworkCore;
public class CarRentalContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        string connectionString = @"server=ERHAN-MATEBOOK;database=CarRentalDb; Trusted_Connection = true;TrustServerCertificate=True";
        optionsBuilder.UseSqlServer(connectionString);
    }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Rental> Rentals { get; set; }
}