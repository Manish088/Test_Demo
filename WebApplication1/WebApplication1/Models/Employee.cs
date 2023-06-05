using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string EmpName { get; set; }
        [Required]
        public string EmpEmail { get; set; }
        [Required]
        public string EmpPassword { get; set; }
        public long EmpMobile { get; set; }
        public string EmpAddress { get; set; }
    }
}
