using CORE.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, FarmerContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (FarmerContext context = new FarmerContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join o in context.Orders
                             on p.OrderId equals o.OrderId
                             join cu in context.Customers
                             on p.CustomerId equals cu.CustomerId
                             join f in context.Farmers
                             on p.FarmerId equals f.FarmerId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitPrice = p.UnitPrice,
                                 UnitInStock = p.UnitInStock,
                                 CustomerName = cu.CustomerName,
                                 FarmerFullName = f.FarmerFullName,
                                 OrderDate = o.OrderDate // Eğer OrderDate yoksa ShipDate kullanabilirsiniz
                             };

                return result.ToList();
            }
        }
        public void AddProduct(Product product)
        {
            using (var context = new FarmerContext())
            {
                context.Products.Add(product);  // Yeni ürünü ekle
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }
        public List<Product> GetAllProducts()
        {
            using (var context = new FarmerContext())
            {
                return context.Products.ToList();  // Tüm ürünleri getir
            }
        }
        public Product GetProductById(int productId)
        {
            using (var context = new FarmerContext())
            {
                return context.Products.FirstOrDefault(p => p.ProductId == productId);  // Id'ye göre ürünü getir
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var context = new FarmerContext())
            {
                context.Products.Update(product);  // Ürünü güncelle
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }
        public void DeleteProduct(Product product)
        {
            using (var context = new FarmerContext())
            {
                context.Products.Remove(product);  // Ürünü sil
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }

    }
}
