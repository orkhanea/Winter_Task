using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Winter_Task.Models
{
    public class ProductReview
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Fullname { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Website { get; set; }

        [Column(TypeName ="tinyint")]
        public int RatingAmount { get; set; }

        public DateTime CreatedDate { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Product Product { get; set; }



    }
}
