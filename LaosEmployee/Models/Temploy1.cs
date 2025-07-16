using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LaosEmployee.Models
{
    public class Temploy1
    {
        [Key]
        [DisplayName("Employee ID")]
        public required string Id { get; set; }

        [DisplayName("First Name")]
        public string? Fname { get; set; }

        [DisplayName("Last Name")]
        public string? Lname { get; set; }
        public string? Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime DateOfResign { get; set; }
        public decimal Salary { get; set; }
        public string? Division { get; set; }
        public string? Department { get; set; }
        public string? Section { get; set; }

        [DisplayName("Employee Status")]
        public string? Status { get; set; } // e.g., Active, Inactive
    }
}
