using System;
using System.Collections.Generic;

namespace FinalAssignment.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public decimal? TotalAmount { get; set; }
}
