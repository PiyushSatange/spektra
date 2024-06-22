using System;
using System.Collections.Generic;

namespace FinalAssignment.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public string? Brand { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }
}
