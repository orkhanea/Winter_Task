using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Winter_Task.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string ProductName { get; set; }

        [Column (TypeName ="decimal")]
        public decimal Price { get; set; }

        public bool isStock { get; set; }

        [MaxLength(1000)]
        public string Text { get; set; }

        [MaxLength(50)]
        public int Quantity { get; set; }

        [MaxLength(10)]
        public string Width { get; set; }

        [MaxLength(50)]
        public string SubTitle { get; set; }

        [MaxLength(200)]
        public string Link { get; set; }

        [MaxLength(10)]
        public string Height { get; set; }

        [MaxLength(10)]
        public string Debth { get; set; }

        [MaxLength(10)]
        public string Weight { get; set; }

        [MaxLength(10)]
        public string QualityChecking { get; set; }

        [MaxLength(10)]
        public string FreshnessDuration { get; set; }

        [MaxLength(50)]
        public string WhenPacking { get; set; }

        [MaxLength(10)]
        public string BoxContains { get; set; }

        [MaxLength(1000)]
        public string Desrciption { get; set; }

        public bool CreatedDate { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        [ForeignKey("ProductCategory")]
        public int ProductCategoryId { get; set; }

        public ProductCategory ProductCategory { get; set; }

        [ForeignKey("Gender")]
        public int GenderId { get; set; }

        public Gender Gender { get; set; }

        public List<ProductReview> ProductReview { get; set; }
        public List<ProductImage> ProductImage { get; set; }
        public List<ProductComment> ProductComment { get; set; }






    }
}
