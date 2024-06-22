using System.ComponentModel.DataAnnotations.Schema;

namespace MobileShoopy.Models
{
    public class Procedure
    {
        public int Oid { get; set; }
        public string? Cname { get; set; }
        public string? Mtitle { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
    }
}
