using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace EShop_BD_1280429.Models
{
    public static class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            context.Users.AddOrUpdate(e => e.UserId,
           new User
           {
               UserId = 1,
               Name = "admin",
               Email = "admin@gmail.com",
               Password = "12345",
               RoleType = 1,

           },
           new User
           {
               UserId = 2,
               Name = "monir",
               Email = "monir@gmail.com",
               Password = "123",
               RoleType = 2,

           },
           new User
           {
               UserId = 3,
               Name = "shefain",
               Email = "shefain@gmail.com",
               Password = "123",
               RoleType = 2,

           }
           );


            context.Categories.AddOrUpdate(
                 c => c.CategoryId,
                 new Category { CategoryId = 1, Name = "Smart Phone" },
                 new Category { CategoryId = 2, Name = "Button Phone" }

                );


            context.Products.AddOrUpdate(p => p.ProductId,

                new Product { ProductId = 1, Name = "IPhone", Description = "Black IPhone", Unit = 85000, Image = "insta-item1.jpg", CategoryId = 1, Popularity = 1 },
                new Product { ProductId = 2, Name = "IPhone2", Description = "Black Phone", Unit = 90000, Image = "insta-item3.jpg", CategoryId = 2, Popularity = 1 },
                new Product { ProductId = 3, Name = "IPhone3", Description = "Phone", Unit = 100000, Image = "product-item3.jpg", CategoryId = 1, Popularity = 1 },
                new Product { ProductId = 4, Name = "IPhone4", Description = "Phone", Unit = 70000, Image = "product-item4.jpg", CategoryId = 2, Popularity = 1 },
                new Product { ProductId = 5, Name = "IPhone5", Description = "Phone", Unit = 80000, Image = "product-item5.jpg", CategoryId = 1, Popularity = 1 },
                new Product { ProductId = 6, Name = "IPhone6", Description = "Phone", Unit = 90000, Image = "single-image1.png", CategoryId = 2, Popularity = 1 },
                new Product { ProductId = 7, Name = "IPhone7", Description = "Phone", Unit = 60000, Image = "product-item1.jpg", CategoryId = 1, Popularity = 1 },


                new Product
                {
                    ProductId = 8,
                    Name = "IPhone8",
                    Description = "Sample IPhone",
                    Unit = 101000,
                    Image = "cart-item1.jpg",
                    CategoryId = 2,
                    Popularity = 1
                }

                );
        }

    }
}