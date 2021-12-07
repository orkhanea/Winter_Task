﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Winter_Task.Models
{
    public class ShippingDetail
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Text { get; set; }

        [MaxLength(200)]
        public string Link { get; set; }

        [MaxLength(250)]
        public string Background { get; set; }

        [NotMapped]
        public IFormFile BackgroundFile { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }



    }
}
