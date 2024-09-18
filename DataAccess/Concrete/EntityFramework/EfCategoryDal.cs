using CORE.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, FarmerContext>, ICategoryDal
    {
        public Category GetCategoryByName(string categoryName)
        {
            using (FarmerContext context = new FarmerContext())
            {
                return context.Categories.FirstOrDefault(c => c.CategoryName == categoryName);
            }
        }
        public void AddCategory(Category category)
        {
            using (FarmerContext context = new FarmerContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        // Tüm kategorileri getirme
        public List<Category> GetAllCategories()
        {
            using (FarmerContext context = new FarmerContext())
            {
                return context.Categories.ToList();
            }
        }

        // Id'ye göre kategori getirme
        public Category GetCategoryById(int categoryId)
        {
            using (FarmerContext context = new FarmerContext())
            {
                return context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            }
        }

        // Kategori güncelleme
        public void UpdateCategory(Category category)
        {
            using (FarmerContext context = new FarmerContext())
            {
                context.Categories.Update(category);
                context.SaveChanges();
            }
        }

        // Kategori silme
        public void DeleteCategory(Category category)
        {
            using (FarmerContext context = new FarmerContext())
            {
                context.Categories.Remove(category);
                context.SaveChanges();
            }
        }
    }
}
