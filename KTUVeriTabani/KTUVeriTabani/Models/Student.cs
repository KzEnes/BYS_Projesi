﻿namespace KTUVeriTabani.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? AdvisorID { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string Department { get; set; } 

  
        public Advisor Advisor { get; set; } 

        public ICollection<StudentCourseSelection> StudentCourseSelections { get; set; } = new List<StudentCourseSelection>();
    }
}
