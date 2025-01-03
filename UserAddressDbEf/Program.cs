using System.Data.Common;
using UserAddressDbEf;
using UserAddressDbEf.Models;
using UserAddressDbEf.Services;

class Program
{
    static void Main(string[] args)
    {
        using var db = new AppDbContext();

        // Seed the database
        DatabaseSeeder.Seed(db);

        Console.WriteLine("Application started.");
        // Console.WriteLine(args[0]);


        // Console.WriteLine("Please search by ID o Name");
        // var searchInput = Console.ReadLine();

        // Console.WriteLine("You searched for " + searchInput);

        Console.WriteLine("All Users!");
        var queryAllUsers = db.Users.OrderBy(user => user.FirstName);

        foreach (var user in queryAllUsers)
        {
            Console.WriteLine(user.FirstName);
        }
    }
}
