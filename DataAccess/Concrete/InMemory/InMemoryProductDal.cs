using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {


        List<Product> _products;


        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                  new Product { ProductId = 1, CategoryId = 1, ProductName = "Tahıl", UnitInStock = 500, UnitPrice = 50 },
                  new Product { ProductId = 2, CategoryId = 2, ProductName = "Süt Ürünleri", UnitInStock = 600, UnitPrice = 55 },
                  new Product { ProductId = 3, CategoryId = 2, ProductName = "Hayvansal Gıdalar", UnitInStock = 400, UnitPrice = 60 }

            };

        }






        public void Add(Product product)
        {
            _products.Add(product);
        }




        public List<Product> GetAll()
        {
            return _products;
        }




        public Product GetById(int productId)
        {
            return _products.SingleOrDefault(p => p.ProductId == productId);
        }





        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }





        public void Update(Product product)
        {
            //Gönderdiğim ürün Id değerine sahip olan ürünü listeden bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }


        public void Delete(Product product)
        {
            // LINQ - Language Integrated Query 
            // => Lambda
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);// LINQ ile yazıyoruz .
            _products.Remove(productToDelete);
        }
    }
}
