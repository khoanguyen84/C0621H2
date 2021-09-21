using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Fullname is required")]
        public string Fullname { get; set; }
        public bool Gender { get; set; }
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date, ErrorMessage = "Dob is required")]
        [Required]
        public DateTime Dob { get; set; }
    }
}
