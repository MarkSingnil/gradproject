using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tennisclub.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
                
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Employee Type")]
        public string EmployeeType { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime StartDate { get; set; }


        [Required(ErrorMessage = "Required")]
        [Display(Name = "Coach's Image")]
        public string ImagePath { get; set; }
    }
}