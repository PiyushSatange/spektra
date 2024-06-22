using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models;

public partial class PracticeContext : DbContext
{
    public PracticeContext()
    {
    }

    public PracticeContext(DbContextOptions<PracticeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-6K77UK\\SQLEXPRESS; Initial Catalog=practice; Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__employee__128545C9C368C470");

            entity.ToTable("employee", tb => tb.HasTrigger("On_Insert"));

            entity.Property(e => e.EmpId)
                .ValueGeneratedNever()
                .HasColumnName("emp_ID");
            entity.Property(e => e.DeptName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DEPT_NAME");
            entity.Property(e => e.EmpName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("emp_NAME");
            entity.Property(e => e.Salary).HasColumnName("SALARY");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__users__B9BE370FB660CC4A");

            entity.ToTable("users");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("user_id");
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.UserName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("user_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
