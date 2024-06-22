using System;
using System.Collections.Generic;

namespace MobileShoopy.Models;

public partial class Mobile
{
    public int Mid { get; set; }

    public string Mtitle { get; set; } = null!;

    public string Mdetails { get; set; } = null!;

    public string Msrc { get; set; } = null!;

    public int Mrating { get; set; }

    public decimal Price { get; set; }

    public int quantity { get; set; }
}
