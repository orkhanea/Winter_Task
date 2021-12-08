using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Winter_Task.Models;

namespace Winter_Task.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        { }
            public DbSet<Banner> Banners { get; set; }
            public DbSet<BillingDetail> BillingDetails { get; set; }
            public DbSet<Blog> Blogs { get; set; }
            public DbSet<BlogCategory> BlogCategories { get; set; }
            public DbSet<BlogComment> BlogComments { get; set; }
            public DbSet<Brand> Brands { get; set; }
            public DbSet<Contact> Contacts { get; set; }
            public DbSet<Country> Countries { get; set; }
            public DbSet<Gender> Genders { get; set; }
            public DbSet<Instagram> Instagrams { get; set; }
            public DbSet<Message> Messages { get; set; }
            public DbSet<NewsLetter> NewsLetters { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<ProductCategory> ProductCategories { get; set; }
            public DbSet<ProductComment> ProductComments { get; set; }
            public DbSet<ProductImage> ProductImages { get; set; }
            public DbSet<ProductReview> ProductReviews { get; set; }
            public DbSet<Setting> Settings { get; set; }
            public DbSet<ShippingDetail> ShippingDetails { get; set; }
            public DbSet<Social> Socials { get; set; }
            public DbSet<User> Users { get; set; }
    }
    
}
