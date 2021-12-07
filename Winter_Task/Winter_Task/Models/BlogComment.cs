using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Winter_Task.Models
{
    public class BlogComment
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Fullname { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Website { get; set; }

        [MaxLength(500)]
        public string Text { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Blog")]
        public int BlogId { get; set; }

        public Blog Blog { get; set; }

        [ForeignKey("ParentBlogComment")]
        public int ParentBlogCommentId { get; set; }

        public BlogComment ParentBlogComment { get; set; }



    }
}
