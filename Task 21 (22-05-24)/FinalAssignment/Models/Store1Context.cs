using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FinalAssignment.Models;

public partial class Store1Context : DbContext
{
    public Store1Context()
    {
    }

    public Store1Context(DbContextOptions<Store1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-6K77UK\\SQLEXPRESS; Initial Catalog=Store1; Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__1788CC4C8716B998");

            entity.ToTable("Customer");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Orders__C3905BCFA8C449CA");

            entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");

            //entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
            //    .HasForeignKey(d => d.CustomerId)
            //    .HasConstraintName("FK__Orders__Customer__3B75D760");

            //entity.HasOne(d => d.Product).WithMany(p => p.Orders)
            //    .HasForeignKey(d => d.ProductId)
            //    .HasConstraintName("FK__Orders__ProductI__3C69FB99");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6CDAF757D18");

            entity.ToTable("Product");

            entity.Property(e => e.Brand)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
