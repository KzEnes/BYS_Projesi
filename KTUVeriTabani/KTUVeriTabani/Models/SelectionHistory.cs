﻿using SmartCourseSelectorWeb.Models;
using System.ComponentModel.DataAnnotations;

namespace KTUVeriTabani.Models
{
    public class SelectionHistory
    {
        [Key]
        public int StudentID { get; set; }  
        public DateTime SelectionDate { get; set; }  

     
        public virtual Student? Student { get; set; }
    }
}
