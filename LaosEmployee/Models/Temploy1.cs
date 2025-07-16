namespace LaosEmployee.Models
{
    public class Temploy1
    {
        public required string Id { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfJoining { get; set; }
        public DateTime DateOfResign { get; set; }
        public decimal Salary { get; set; }
        public string? Division { get; set; }
        public string? Department { get; set; }
        public string? Section { get; set; }
        public string? Status { get; set; } // e.g., Active, Inactive
    }
}
