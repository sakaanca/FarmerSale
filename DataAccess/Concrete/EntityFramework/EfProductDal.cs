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
    }
}
