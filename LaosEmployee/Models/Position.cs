using System.ComponentModel.DataAnnotations;

namespace LaosEmployee.Models
{
    public class Position
    {
        [Key]
        [Required]
        public string Id { get; set; } = string.Empty;
        [Required]
        public string Username { get; set; } = string.Empty;
    }
}
