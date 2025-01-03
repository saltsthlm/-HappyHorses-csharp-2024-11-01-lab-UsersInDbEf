using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using UserAddressDbEf;
using UserAddressDbEf.Models;
using UserAddressDbEf.Services;


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
var inputValue = args[0];


static void filterByName(string inputValue)
{
    using var db = new AppDbContext();

    var filteredArray = db.Users
                    .Where(user => user.FirstName
                    .StartsWith(inputValue))
                    .Select(user => new { user.FirstName, user.LastName })
                    .ToList();

    foreach (var user in filteredArray)
    {
        Console.WriteLine($"{user.FirstName}, {user.LastName}");
    }
}
