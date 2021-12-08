using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter_Task.Models;

namespace Winter_Task.ViewModel
{
    public class VmShopCatagory
    {
        public List<Product> products { get; set; }
        public List<Brand> brands { get; set; }
        public List<ProductCategory> productCategories { get; set; }
        public List<ProductImage> productImages { get; set; }
        public List<ShippingDetail> shippingDetails { get; set; }
       
    }
}
