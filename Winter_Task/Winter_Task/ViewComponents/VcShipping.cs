using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter_Task.Data;
using Winter_Task.Models;

namespace Winter_Task.ViewComponents
{
    public class VcShipping:ViewComponent
    {
        private readonly AppDbContext _context;

        public VcShipping(AppDbContext context)
        {
           _context = context;
        }

        public IViewComponentResult Invoke()
        {
            List<ShippingDetail> model = _context.ShippingDetails.ToList();


            return View(model);
        }
    }
}
