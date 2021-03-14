using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MG_LAB2.Models
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private MyProductsContext context;

        public EFCategoryRepository(MyProductsContext CategoryContext)
        {
            context = CategoryContext;
        }

        public IEnumerable<Category> Categories => context.Categories;

        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }


        public void DeleteCategory(int categoryID)
        {
            Category categoryInstance = context.Categories.Where(a => a.CategoryId == categoryID).FirstOrDefault();
            context.Categories.Remove(categoryInstance);
            context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            Category categoryInstance = context.Categories.Where(m => m.CategoryId == category.CategoryId).FirstOrDefault();
            categoryInstance.Name = category.Name;
            context.Categories.Update(categoryInstance);
            context.SaveChanges();
        }
    }
}
