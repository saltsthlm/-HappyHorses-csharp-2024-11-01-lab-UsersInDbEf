using UserAddressDbEf;
using UserAddressDbEf.Models;

namespace UserAddressDbEf.Services;

public static class DatabaseSeeder
{
    public static void Seed(AppDbContext context)
    {
        if (context.Users.Any())
        {
            Console.WriteLine("Database already seeded.");
            return;
        }

        var users = new List<User>
        {
            new User
            {
                FirstName = "Kalle",
                LastName = "Johansson",
                Email = "kalle@example.com",
                Address = new Address
                {
                    Street = "Viking Road",
                    City = "Stockholm",
                    PostalCode = "12345"
                }
            },
            new User
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Address = new Address
                {
                    Street = "Maple Street",
                    City = "Gothenburg",
                    PostalCode = "56789"
                }
            },new User
            {
                FirstName = "Emma",
                LastName = "Johnson",
                Email = "emma.j@example.com",
                Address = new Address
                {
                    Street = "Birch Avenue",
                    City = "Malmö",
                    PostalCode = "11223"
                }
            },
            new User
            {
                FirstName = "Liam",
                LastName = "Brown",
                Email = "liam.b@example.com",
                Address = new Address
                {
                    Street = "Oak Lane",
                    City = "Uppsala",
                    PostalCode = "33445"
                }
            },
            new User
            {
                FirstName = "Olivia",
                LastName = "Davis",
                Email = "olivia.d@example.com",
                Address = new Address
                {
                    Street = "Pine Road",
                    City = "Helsingborg",
                    PostalCode = "55667"
                }
            },
            new User
            {
                FirstName = "Noah",
                LastName = "Smith",
                Email = "noah.s@example.com",
                Address = new Address
                {
                    Street = "Elm Street",
                    City = "Lund",
                    PostalCode = "77889"
                }
            },
            new User
            {
                FirstName = "Ava",
                LastName = "Miller",
                Email = "ava.m@example.com",
                Address = new Address
                {
                    Street = "Cedar Lane",
                    City = "Västerås",
                    PostalCode = "99001"
                }
            },
            new User
            {
                FirstName = "William",
                LastName = "Anderson",
                Email = "william.a@example.com",
                Address = new Address
                {
                    Street = "Ash Street",
                    City = "Örebro",
                    PostalCode = "22334"
                }
            },
            new User
            {
                FirstName = "Sophia",
                LastName = "Taylor",
                Email = "sophia.t@example.com",
                Address = new Address
                {
                    Street = "Fir Avenue",
                    City = "Linköping",
                    PostalCode = "44556"
                }
            },
            new User
            {
                FirstName = "James",
                LastName = "White",
                Email = "james.w@example.com",
                Address = new Address
                {
                    Street = "Spruce Boulevard",
                    City = "Jönköping",
                    PostalCode = "66778"
                },
            },
        };

        context.Users.AddRange(users);
        context.SaveChanges();

        Console.WriteLine("10 users with addresses added to the database.");
    }
}
