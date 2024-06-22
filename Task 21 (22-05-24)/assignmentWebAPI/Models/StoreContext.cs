using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace assignmentWebAPI.Models;

public partial class StoreContext : DbContext
{
    public StoreContext()
    {
    }

    public StoreContext(DbContextOptions<StoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<StoreOrder> StoreOrders { get; set; }

    public virtual DbSet<StoreProduct> StoreProducts { get; set; }

    public virtual DbSet<StoreUser> StoreUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-6K77UK\\SQLEXPRESS; Initial Catalog=Store; Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StoreOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__StoreOrd__3214EC07B0E78246");

            entity.ToTable("StoreOrder");

            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

            entity.HasOne(d => d.User).WithMany(p => p.StoreOrders)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StoreOrde__UserI__5441852A");

            entity.HasMany(d => d.Products).WithMany(p => p.Orders)
                .UsingEntity<Dictionary<string, object>>(
                    "OrderProduct",
                    r => r.HasOne<StoreProduct>().WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__OrderProd__Produ__534D60F1"),
                    l => l.HasOne<StoreOrder>().WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__OrderProd__Order__52593CB8"),
                    j =>
                    {
                        j.HasKey("OrderId", "ProductId").HasName("PK__OrderPro__08D097A334E98FC2");
                        j.ToTable("OrderProduct");
                    });
        });

        modelBuilder.Entity<StoreProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__StorePro__3214EC07DFEB3135");

            entity.ToTable("StoreProduct");

            entity.Property(e => e.Disc)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<StoreUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__StoreUse__3214EC07CF1C3C9E");

            entity.ToTable("StoreUser");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNo)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
