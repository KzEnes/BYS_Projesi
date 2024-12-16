using System.ComponentModel.DataAnnotations;

namespace VeriTabaniProjesi.Models
{
    public class Course
    {
        [Key]
        public int course_ID { get; set; }
        [Required]
        public string course_name { get; set; } = "";
        [Required]
        public int credits { get; set; }
        public int instructor_ID { get; set; }
        public ICollection<StudentCourse> studentcourses { get; set; }
    }
}
