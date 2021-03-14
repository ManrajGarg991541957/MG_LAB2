using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MG_LAB2.Models
{
    public class InitialData
    {
        public static void DataPopulated(IApplicationBuilder app)
        {
            Product_DBContext context = app.ApplicationServices
                                    .CreateScope().ServiceProvider
                                    .GetRequiredService<Product_DBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(

                    new Category
                    {
                        Name = "Electronics"
                    },
                    new Category
                    {
                        Name = "Food"
                    },
                    new Category
                    {
                        Name = "Vehicles"
                    });

                context.SaveChanges();
            }
            if(!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Television",
                        Price = 100,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Name = "Phone",
                        Price = 80,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Name = "Coca-Cola",
                        Price = 1,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Name = "Tablet",
                        Price = 70,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Name = "Car",
                        Price = 70000,
                        CategoryId = 3
                    });

            context.SaveChanges();
             }

            }
        }
    }

