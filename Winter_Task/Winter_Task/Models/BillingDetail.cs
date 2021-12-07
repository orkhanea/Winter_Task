using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Winter_Task.Models
{
    public class BillingDetail
    {
        [Key]
        public int Id { get; set; }
        
        [MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(20)]
        public string Surname { get; set; }
        
        [MaxLength(50)]
        public string CompanyName { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Address1 { get; set; }

        [MaxLength(100)]
        public string Address2 { get; set; }

        [MaxLength(100)]
        public string TownAndCity { get; set; }

        [MaxLength(100)]
        public string District { get; set; }

        [MaxLength(20)]
        public string PostalCode { get; set; }

        public bool isCreateAccount { get; set; }

        [Column(TypeName ="ntext")]
        public string OrderNote { get; set; }

        public DateTime CreatedDate { get; set; }
        
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country Country { get; set; }



       






    }
}
