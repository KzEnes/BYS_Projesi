﻿using System.ComponentModel.DataAnnotations;

namespace KTUVeriTabani.Models
{
    public class Advisor
    {
        [Key]
        public int AdvisorID { get; set; } // Primary Key
        public string FullName { get; set; } // Akademisyen Adı Soyadı
        public string Title { get; set; } // Unvan
        public string Department { get; set; } // Bölüm
        public string Email { get; set; } // E-posta (Unique)

        // Navigation Property
        public ICollection<Student> Students { get; set; } // Danışmana bağlı öğrenciler
    }
}
