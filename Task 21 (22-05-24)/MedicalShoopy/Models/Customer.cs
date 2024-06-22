using System;
using System.Collections.Generic;

namespace MedicalShoopy.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public long? PhoneNo { get; set; }

    public string? Location { get; set; }
}
