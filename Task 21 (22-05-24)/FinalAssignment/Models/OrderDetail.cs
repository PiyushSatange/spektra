using System.ComponentModel.DataAnnotations;

namespace FinalAssignment.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderId { get; set; }
        public string? CustomerName { get; set; }
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
