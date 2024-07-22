using System.ComponentModel.DataAnnotations;

namespace DemoAPINetCore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Title { get; set; }

        public string?Description { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}
