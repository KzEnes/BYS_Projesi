using System.ComponentModel.DataAnnotations;

namespace VeriTabaniProjesi.Models
{
    public class Student
    {
        [Key]
        public int student_ID { get; set; }
        [Required]
        public string name { get; set; } = "";
        [Required]
        public string surname { get; set; } = "";
        [EmailAddress]
        public string email { get; set; } = "";
        [Required]
        public string password { get; set; } = "";
        [Required]
        public string major { get; set; } = "";
        [Required]
        public string courses_selected { get; set; } = "";

        public ICollection<StudentCourse> studentcourses { get; set; }
    }
}
