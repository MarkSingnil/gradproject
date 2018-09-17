using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tennisclub.DAL
{
    public class UserRole : IdentityRole
    {
        public UserRole() : base() { }
        public UserRole(string Name) : base() { }
    }
}