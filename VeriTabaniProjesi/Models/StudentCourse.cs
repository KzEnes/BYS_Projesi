namespace VeriTabaniProjesi.Models
{
    public class StudentCourse
    {
        public int student_ID { get; set; }
        public Student student { get; set; }

        public int course_ID { get; set; }
        public Course course { get; set; }
    }
}
