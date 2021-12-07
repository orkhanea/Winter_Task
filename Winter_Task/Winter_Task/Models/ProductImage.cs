using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Winter_Task.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(30)]
        public string Image { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [ForeignKey("Product")]
        [MaxLength(200)]
        public int ProductId { get; set; }

        public Product Product { get; set; }


    }
}
