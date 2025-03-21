using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using RazorWebAppEFCore.Models;

namespace RazorWebAppEFCore.Data;

public partial class ContosoPizzaPart1Context : DbContext
{
    public ContosoPizzaPart1Context()
    {
    }

    public ContosoPizzaPart1Context(DbContextOptions<ContosoPizzaPart1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<Product> Products { get; set; }
       
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
