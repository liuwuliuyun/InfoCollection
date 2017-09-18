using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace WebRole1.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }
        public string LoginTime { get; set; }
        public string LoginIpAddr { get; set; }
    }

    public class UserInfoDBContext: DbContext
    {
        public DbSet<UserInfo> UserDataCollection { get; set; }
    }
}