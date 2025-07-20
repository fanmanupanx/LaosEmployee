using System.ComponentModel.DataAnnotations;

namespace LaosEmployee.Models
{
    public class UserLogin    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;

        public string? ErrorMessage { get; set; }

        public int Active { get; set; } = 1;
    }
}
