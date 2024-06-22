using System;
using System.Collections.Generic;

namespace assignmentWebAPI.Models;

public partial class StoreUser
{
    public int UserId { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public string PhoneNo { get; set; } = null!;

    public virtual ICollection<StoreOrder> StoreOrders { get; set; } = new List<StoreOrder>();
}
