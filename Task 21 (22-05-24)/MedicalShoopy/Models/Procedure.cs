using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalShoopy.Models
{
    public class Procedure
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Name { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
    }
}
