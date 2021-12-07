using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Winter_Task.Models
{
    public class Social
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string SocialIcon { get; set; }

        [MaxLength(200)]
        public string SocialLink { get; set; }


    }
}
