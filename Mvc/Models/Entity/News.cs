using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.Models.Entity
{
    public class News
    {

        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Title { get; set; }
        public string ShortDescribe { get; set; }
        public string Describe { get; set; }
        public DateTime NewsDate { get; set; }


        public virtual Account Account { get; set; }
        public virtual ICollection<NewsLike> NewsLikes { get; set; }
        public virtual ICollection<NewsCommand> NewsCommands { get; set; }
    }
}