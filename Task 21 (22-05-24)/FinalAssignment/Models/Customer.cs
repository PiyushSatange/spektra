using System;
using System.Collections.Generic;

namespace FinalAssignment.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public long? Number { get; set; }

}
