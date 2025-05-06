using System.ComponentModel.DataAnnotations;

namespace SPEntity.Model
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]

        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Range(18, 70)]
        public int Age { get; set; }
        [Required]
        public string? Department { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
