using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using static Mvc.Models.Enum.Enum;

namespace Mvc.Models.Entity
{
    public class Account
    {

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public bool IsBlock { get; set; }
        public DateTime  RegisterDate { get; set; }

        public AccountTypes AccountType { get; set; }

        public virtual ICollection<News> Newses { get; set; }
        public virtual ICollection<NewsLike> NewsLikes { get; set; }
        public virtual ICollection<NewsCommand> NewsCMD { get; set; }


    }
}