using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace StoreManagement.Models
{
    public class User
    {
        public int userId { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? Email { get; set; }

        [Required]
        public string? number { get; set; }

        public List<Order> orders { get; set; } = new List<Order>();
    }
}
