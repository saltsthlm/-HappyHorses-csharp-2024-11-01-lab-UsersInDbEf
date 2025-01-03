using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class UserAdressContext : DbContext
{
    public DbSet<User>? Users { get; set; }
    public DbSet<Adress>? Adress { get; set; }

    public string DbPath { get; }

    public UserAdressContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "localhost.db");
    }


    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer($"Data Source={DbPath}");
}

public class User
{
    [Key]
    public int UserId { get; set; }
    public int Name { get; set; }

    public List<Adress> Adress { get; } = new();
}

public class Adress
{
    public int AdressId { get; set; }
    public string PostalCode { get; set; }
    public string StreetName { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }
}