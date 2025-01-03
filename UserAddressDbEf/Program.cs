using System.Data.Common;
using UserAddressDbEf;
using UserAddressDbEf.Models;
using UserAddressDbEf.Services;

class Program
{
    static void Main(string[] args)
    {

        using var db = new AppDbContext();

        Console.WriteLine("Application started.");

        DatabaseSeeder.Seed(db);

        if (args.Length < 1)
        {
            Console.WriteLine("All Users!");
            var queryAllUsers = db.Users.OrderBy(user => user.FirstName);

            foreach (var user in queryAllUsers)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName);
            }
        }
    }

}
