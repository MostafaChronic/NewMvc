using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models.Entity
{
    public class NewsCommand
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int NewsId { get; set; }
        public string Commandtxt { get; set; }
        public DateTime CommandDate { get; set; }
        public virtual Account Account { get; set; }
        public virtual News News { get; set; }
    }
}