using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc.Models.Entity
{
    public class News
    {
        [Key]
        [Required]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required]
        [ScaffoldColumn(false)]
        public int AccountId { get; set; }
        [Required]
        [MaxLength(255, ErrorMessage = "مقدار دهی صحیح نمیباشد")]
        public string Title { get; set; }
        [Required]
        [MaxLength(1000, ErrorMessage = "مقدار دهی صحیح نمیباشد")]
        public string ShortDescribe { get; set; }
        [Required]

        public string Describe { get; set; }
        public DateTime NewsDate { get; set; }

        [ForeignKey("AccountId")]
        public virtual Account Account { get; set; }
        public virtual ICollection<NewsLike> NewsLikes { get; set; }
        public virtual ICollection<NewsCommand> NewsCommands { get; set; }
    }
}