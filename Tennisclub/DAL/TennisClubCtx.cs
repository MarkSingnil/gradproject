using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Tennisclub.Models;
namespace Tennisclub.DAL
{
    public class TennisClubCtx : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeLogin> EmployeeLogins { get; set; }
        public DbSet<Lesson> Lessons {get; set;}
        public DbSet<Enrollment> Enrollments {get; set;}
        public DbSet<Member> Members {get; set;}
    }
}