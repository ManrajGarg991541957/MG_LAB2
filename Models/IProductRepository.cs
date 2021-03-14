using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MG_LAB2.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        //Product this[int id] { get; }

        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
