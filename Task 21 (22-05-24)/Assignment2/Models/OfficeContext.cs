using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Assignment2.Models;

public partial class OfficeContext : DbContext
{
    public OfficeContext()
    {
    }

    public OfficeContext(DbContextOptions<OfficeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-6K77UK\\SQLEXPRESS; Initial Catalog=Office; Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC07C5B71EC0");

            entity.ToTable("Employee");

            entity.Property(e => e.Designation).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(15);
            entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    public void getAllEmployees()
    {
        Console.WriteLine("--------------------------------------------------------------------------------------------------");
        Console.WriteLine("|{0,-5}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "ID", "First Name", "Last Name", "Phone No", "Designation", "Salary");
        Console.WriteLine("--------------------------------------------------------------------------------------------------");
        Employees.ToList().ForEach(e => {
            Console.WriteLine("|{0,-5}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", e.Id, e.FirstName, e.LastName, e.PhoneNumber, e.Designation, e.Salary);     
        });
        Console.WriteLine("--------------------------------------------------------------------------------------------------");
    }

    public void getEmployeeById(int id)
    {
        Employee e = Employees.Find(id);
        Console.WriteLine("--------------------------------------------------------------------------------------------------");
        Console.WriteLine("|{0,-5}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}", "ID", "First Name", "Last Name", "Phone No", "Designation", "Salary");
        Console.WriteLine("--------------------------------------------------------------------------------------------------");
        Console.WriteLine("|{0,-5}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}", e.Id, e.FirstName, e.LastName, e.PhoneNumber, e.Designation, e.Salary);
        Console.WriteLine("--------------------------------------------------------------------------------------------------");

    }

    public void addEmployee(Employee e)
    {
        Employees.Add(e);
        SaveChanges();
        Console.WriteLine("Employee added successfully");
    }

    public void update()
    {
        Console.WriteLine("Enter the employee id");
        int id = Convert.ToInt32(Console.ReadLine());

        Employee e = Employees.Find(id);
        if (e != null)
        {
            Console.WriteLine("Press 1 : Update First Name");
            Console.WriteLine("Press 2 : Update Last Name");
            Console.WriteLine("Press 3 : Update Phone Number");
            Console.WriteLine("Press 4 : Update Designation");
            Console.WriteLine("Press 5 : Update Salary");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine("Enter the new first name");
                    string firstname = Console.ReadLine();
                    e.FirstName = firstname;
                    break;
                case 2:
                    Console.WriteLine("Enter the new last name");
                    string lastname = Console.ReadLine();
                    e.LastName = lastname;
                    break;
                case 3:
                    Console.WriteLine("Enter the new phone number");
                    string phoneNo = Console.ReadLine();
                    e.PhoneNumber = phoneNo;
                    break;
                case 4:
                    Console.WriteLine("Enter the new designation");
                    string desg = Console.ReadLine();
                    e.Designation = desg;
                    break;
                case 5:
                    Console.WriteLine("Enter the new salary");
                    decimal salary = Convert.ToDecimal(Console.ReadLine());
                    e.Salary = salary;
                    break;
                default:
                    Console.WriteLine("This was not a valid input");
                    break;
            }
            SaveChanges();
        }
       
    }
}
