using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MobileShoopy.Models;

public partial class OnlineMobileSiteContext : DbContext
{
    public OnlineMobileSiteContext()
    {
    }

    public OnlineMobileSiteContext(DbContextOptions<OnlineMobileSiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Mobile> Mobiles { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Procedure> Procedures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-6K77UK\\SQLEXPRESS; Initial Catalog=OnlineMobileSite; Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Cid).HasName("PK__Customer__D837D05F03A438DA");

            entity.ToTable("Customer");

            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Caddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("caddress");
            entity.Property(e => e.Cemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cemail");
            entity.Property(e => e.Cname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cname");
            entity.Property(e => e.Cnumber).HasColumnName("cnumber");
        });

        modelBuilder.Entity<Mobile>(entity =>
        {
            entity.HasKey(e => e.Mid).HasName("PK__Mobile__DF5032ECF6002ACD");

            entity.ToTable("Mobile");

            entity.Property(e => e.Mid).HasColumnName("mid");
            entity.Property(e => e.Mdetails)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("mdetails");
            entity.Property(e => e.Mrating).HasColumnName("mrating");
            entity.Property(e => e.Msrc)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("msrc");
            entity.Property(e => e.Mtitle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mtitle");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Oid).HasName("PK__Orders__C2FFCF13E341D73D");

            entity.Property(e => e.Oid).HasColumnName("oid");
            entity.Property(e => e.Cid).HasColumnName("cid");
            entity.Property(e => e.Mid).HasColumnName("mid");
        });

        modelBuilder.Entity<Procedure>(entity =>
        {
            entity.HasKey(e => e.Oid).HasName("PK__Orders__C2FFCF13E341D73D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
