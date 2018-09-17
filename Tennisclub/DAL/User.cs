using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tennisclub.Models;
namespace Tennisclub.DAL
{
    public class User : IdentityUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string LoginType { get; set; }

        public static User GetUserDetails(User user)
        {
            TennisClubCtx db = new TennisClubCtx();
            

            return (User)db.EmployeeLogins.Where(u => u.Login.ToLower() == user.Login.ToLower() && u.Password == user.Password);
        }

    }
}