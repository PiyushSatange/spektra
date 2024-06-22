using System;
using System.Collections.Generic;

namespace assignmentWebAPI.Models;

public partial class StoreOrder
{
    public int OrderId { get; set; }

    public DateOnly OrderDate { get; set; }

    public int UserId { get; set; }

    public decimal Total { get; set; }

    public virtual StoreUser User { get; set; } = null!;

    public virtual ICollection<StoreProduct> Products { get; set; } = new List<StoreProduct>();
}