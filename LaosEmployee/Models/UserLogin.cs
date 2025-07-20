using System.ComponentModel.DataAnnotations;

namespace LaosEmployee.Models
{
    public class UserLogin    {
        public string Id { get; set; } = string.Empty;
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;

        public string? ErrorMessage { get; set; }

        public int Active { get; set; } = 1;
    }
}
