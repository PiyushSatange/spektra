using System;
using System.Collections.Generic;

namespace MedicalShoopy.Models;

public partial class Order
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int CustomerId { get; set; }

}
