using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment.Models
{
    public class Product
    {
        public int productId { get; set; }
        public string name { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal price { get; set; }
        public string description { get; set; }
    }
}
