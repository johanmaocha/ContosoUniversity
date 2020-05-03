using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ContosoUniversity.DTOs
{
    public class StudentDTO
    {       
        public int ID { get; set; }

        [Required(ErrorMessage = " El apellido es requerido ")]
        [Display(Name = "Last Name ")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Firs tMidName ")]
        public string FirstMidName { get; set; }

        [Required(ErrorMessage = " la fecha es requerida")]
        [Display(Name = " Enrollment Date ")]
        public DateTime EnrollmentDate { get; set; }

       
    }
}
