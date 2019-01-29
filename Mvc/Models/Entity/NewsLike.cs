using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models.Entity
{
    public class NewsLike
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int NewsId { get; set; }
        public DateTime  LikeDate { get; set; }

        public virtual Account Account { get; set; }
        public virtual News News { get; set; }
    }
}