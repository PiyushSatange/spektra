using System;
using System.Collections.Generic;

namespace Model2_Assignment1.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string? Email { get; set; }

    public int? Amount { get; set; }
}
