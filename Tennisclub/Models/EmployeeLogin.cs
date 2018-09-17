using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tennisclub.Models
{
    public class EmployeeLogin
    {
        [Key]
        public int LoginID { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string LoginType { get; set; }

        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

    }
}