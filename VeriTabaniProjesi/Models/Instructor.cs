using System.ComponentModel.DataAnnotations;

namespace VeriTabaniProjesi.Models
{
    public class Instructor
    {
        [Key]
        public int instructor_ID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string surname { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public string department { get; set; }
    }
}
