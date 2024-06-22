using System;
using System.Collections.Generic;

namespace EmployeeManagement.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public decimal Salary { get; set; }
}
