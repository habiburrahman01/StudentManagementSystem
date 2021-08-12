using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class StudentClass
    {
        //Data table for class
     
        public int Id { get; set; }

        //Column data type define in the dbContext class using ModelBuilder 
        [Required]
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }

        public ICollection<Student> Students { get; set; }

      
    }
}
