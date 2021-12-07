using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Winter_Task.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [Column(TypeName ="ntext")]
        public string Content { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("BlogCategory")]
        public int BlogCategoryId { get; set; }

        public BlogCategory BlogCategory { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User User { get; set; }

        public List<BlogComment> BlogComment { get; set; }




    }
}
