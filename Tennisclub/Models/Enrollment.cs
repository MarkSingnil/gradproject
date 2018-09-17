using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tennisclub.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int LessonID { get; set; }

        public int MemberID { get; set; }

        public DateTime EnrollDate { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual Member Member { get; set; }
    }
}