using System.ComponentModel.DataAnnotations;

namespace AdminDashboard.Api.DTOS
{
    public class UserDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
    }
}
