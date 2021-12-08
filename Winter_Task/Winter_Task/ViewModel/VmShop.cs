using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter_Task.Models;

namespace Winter_Task.ViewModel
{
    public class VmShop
    {
        public List<Product> products { get; set; }
        public List<ProductImage> productImages { get; set; }
        public List<ProductCategory> productCategories { get; set; }
        public List<Brand> brands{ get; set; }
        public List<Gender> genders{ get; set; }
        public List<ProductComment> productComments{ get; set; }
        public List<ProductReview> productReviews{ get; set; }
        

    }
}
