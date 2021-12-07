using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Winter_Task.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(250)]
        public string Logo { get; set; }
        
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        
        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Copyright { get; set; }

        [MaxLength(200)]
        public string CopyrightLink { get; set; }


    }
}
