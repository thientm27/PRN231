using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessObjects.Dtos
{
    public class ProductDto
    {

        public int? ProductId { get; set; }

        [Required]
        [StringLength(40)]
        public string? ProductName { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int UnitsInStock { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        public CategoryDto? Category { get; set; }
    }
}
