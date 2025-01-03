using Microsoft.EntityFrameworkCore;
using UserAddressDbEf.Models;

namespace UserAddressDbEf;

public class AppDbContext : DbContext
{
    public DbSet<User>? Users { get; set; }
    public DbSet<Address>? Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=UserAddressDb;User Id=sa;Password=Password_2_Change_4_Real_Cases_&;Encrypt=False;TrustServerCertificate=True;");
    }
}
