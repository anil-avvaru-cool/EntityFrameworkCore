using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoPizza.Models;

namespace ContosoPizza.Data;

public class ContosoPizzaContext : DbContext
{
    // Each Dbset match to a table in the database
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;

    public DbSet<Product> Products { get; set; } = null!;

    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;";
        // Encrypt=True
        string connStr = @"Data Source=anil-avvaru-pc;Initial Catalog=ContosoPizza-Part1;Integrated Security=True;Encrypt=False";
        optionsBuilder.UseSqlServer(connStr);
        //optionsBuilder.UseSqlLite(connStr);
    }
}


