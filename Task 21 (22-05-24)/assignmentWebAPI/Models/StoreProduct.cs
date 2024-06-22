using System;
using System.Collections.Generic;

namespace assignmentWebAPI.Models;

public partial class StoreProduct
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Disc { get; set; }

    public virtual ICollection<StoreOrder> Orders { get; set; } = new List<StoreOrder>();
}
