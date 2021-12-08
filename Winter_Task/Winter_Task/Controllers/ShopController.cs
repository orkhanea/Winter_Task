using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Winter_Task.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult ShopCategory()
        {
            return View();
        }

        public IActionResult ProductDetails()
        {
            return View();
        }
    }
}
