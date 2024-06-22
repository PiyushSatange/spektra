using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public User? Customer { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Amount { get; set; }
        public string? PaymentMethod { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
