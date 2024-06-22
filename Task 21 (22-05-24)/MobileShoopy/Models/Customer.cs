using System;
using System.Collections.Generic;

namespace MobileShoopy.Models;

public partial class Customer
{
    public int Cid { get; set; }

    public string Cname { get; set; } = null!;

    public long Cnumber { get; set; }

    public string? Cemail { get; set; }

    public string Caddress { get; set; } = null!;
}
