using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc.Models.Entity
{
    public class Contextes : DbContext
    {
        public DbSet<News> Newses { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<NewsLike> NewsLikes { get; set; }
        public DbSet<NewsCommand> NewsCommands { get; set; }

        public Contextes() : base("name= MusicDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().HasRequired(c => c.Account).WithMany(p=>p.Newses).WillCascadeOnDelete(false);

        }


    }
}