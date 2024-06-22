using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Module2_Assignment5.Models;

public partial class SalaryView
{
    public int EmpId { get; set; }

    public string EmpName { get; set; } = null!;

    public string? DeptName { get; set; }

    public int? Salary { get; set; }
}