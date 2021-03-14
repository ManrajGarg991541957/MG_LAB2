using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MG_LAB2.Models
{
    public class EFProductRepository : IProductRepository
    {
        private Product_DBContext context;

        public EFProductRepository(Product_DBContext ProductContext)
        {
            context = ProductContext;
        }

        public IEnumerable<Product> Products => context.Products;

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }


        public void DeleteProduct(int productID)
        {
            Product productInstance = context.Products.Where(m => m.ProductId == productID).FirstOrDefault();
            context.Products.Remove(productInstance);
            context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            Product productInstance = context.Products.Where(m => m.ProductId == product.ProductId).FirstOrDefault();
            productInstance.Name = product.Name;
            productInstance.Price = product.Price;
            context.Products.Update(productInstance);
            context.SaveChanges();
        }

    }
}
