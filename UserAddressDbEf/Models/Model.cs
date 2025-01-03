using System.ComponentModel.DataAnnotations;

namespace UserAddressDbEf.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }

    public Address? Address { get; set; }
}

public class Address
{
    [Key]
    public int Id { get; set; }
    public required string Street { get; set; }
    public required string City { get; set; }
    public required string PostalCode { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
}
