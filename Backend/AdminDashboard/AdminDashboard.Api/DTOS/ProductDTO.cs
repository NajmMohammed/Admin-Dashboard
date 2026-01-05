using System.ComponentModel.DataAnnotations;

namespace AdminDashboard.Api.DTOS
{
    public class ProductDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public decimal Price { get; set; }

    }
}
