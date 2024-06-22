using System;
using System.Collections.Generic;

namespace Assignment3.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public string? DeptName { get; set; }

    public int? Salary { get; set; }
}
