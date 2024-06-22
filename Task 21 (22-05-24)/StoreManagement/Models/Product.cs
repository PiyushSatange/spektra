using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Models
{
    public class Product
    {
        public int productId { get; set; }

        [Required]
        public string? productName { get; set; }

        [Required]
        public decimal productPrice { get; set; }

        public string? productDescription { get; set;}
    }
}
