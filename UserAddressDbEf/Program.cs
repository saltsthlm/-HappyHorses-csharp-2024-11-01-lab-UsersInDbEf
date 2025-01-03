using UserAddressDbEf;
using UserAddressDbEf.Models;
using UserAddressDbEf.Services;

class Program
{
    static void Main(string[] args)
    {
        using var context = new AppDbContext();

        // Seed the database
        DatabaseSeeder.Seed(context);

        Console.WriteLine("Application started.");
        Console.WriteLine(args[0]);
    }
}
