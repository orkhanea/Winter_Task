using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter_Task.Data;
using Winter_Task.Models;
using Winter_Task.ViewModel;

namespace Winter_Task.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult ShopCategory()
        {
            VmShopCatagory Model = new VmShopCatagory();
            Model.brands = _context.Brands.ToList();
            Model.productImages = _context.ProductImages.ToList();
            Model.products = _context.Products.ToList();
            Model.productCategories = _context.ProductCategories.ToList();
            Model.shippingDetails = _context.ShippingDetails.ToList();
            return View(Model);
        }

        public IActionResult ProductDetails()
        {
            VmShop model = new VmShop();

            model.products = _context.Products.ToList();
            model.productImages = _context.ProductImages.ToList();
            model.brands = _context.Brands.ToList();
            model.productCategories = _context.ProductCategories.ToList();
            model.genders = _context.Genders.ToList();
            model.productComments = _context.ProductComments.ToList();
            model.productReviews = _context.ProductReviews.ToList();
           






            return View(model);
        }
    }
}
