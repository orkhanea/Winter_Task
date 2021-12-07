using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Winter_Task.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(20)]
        public string Firstame { get; set; }

        [MaxLength(20)]
        public string Surname { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        public bool isAdmin { get; set; }

        [MaxLength(50)]
        public string Username { get; set; }

        [MaxLength(250)]
        public string Password { get; set; }   


        [MaxLength(250)]
        public string Image { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<Blog> Blog { get; set; }




    }
}
