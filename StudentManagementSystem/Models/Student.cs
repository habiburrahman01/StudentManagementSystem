using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        //data table for student
        
        
        public int Id { get; set; }

        //Column data type define in the dbContext class using ModelBuilder 
        [Required]
        [Display(Name ="Student Name")]
        public string StudentName { get; set; }

        [Required]
        [Display(Name = "Admission Date")]
        public DateTime AdmissionDate { get; set; }

        [Required]
        [Display(Name = "Class")]
        public int Class { get; set; }
        public StudentClass StudentClass { get; set; }

    }
}
