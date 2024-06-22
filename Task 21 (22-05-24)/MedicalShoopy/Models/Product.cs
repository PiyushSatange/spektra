using System;
using System.Collections.Generic;

namespace MedicalShoopy.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Details { get; set; }

    public string? Src { get; set; }

    public int? Rating { get; set; }

    public decimal? Price { get; set; }

    public int Quantity { get; set; }
}
