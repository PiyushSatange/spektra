using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public List<Product> Products { get; set; } = new List<Product>();

        [Required]
        public User user { get; set; }

        [Required]
        public DateTime DateTime = DateTime.Now;

    }
}
