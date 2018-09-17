using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tennisclub.Models
{
    public class Lesson
    {
        [Key]
        public int LessonID { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Lesson Name")]
        public string LessonName { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Description")]
        public string LessonDescription { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "CoachID")]
        public int EmployeeID { get; set; }

        [DataType(DataType.DateTime)]
        [Required(ErrorMessage = "Required")]
        [Display(Name = "Date of Lesson")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime LessonDate { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }


    }
}