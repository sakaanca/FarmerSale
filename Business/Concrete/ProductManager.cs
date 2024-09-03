using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
            //İş Kodları
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min && p.UnitPrice<=max);// Bu ise iki fiyat aralığında olan datayı getirir.

        }
        public void Add(Product product)
        {
            // İş kuralları
            if (product.ProductName.Length < 2)
            {
                throw new Exception("Ürün adı en az 2 karakter olmalıdır.");
            }

            if (product.UnitPrice <= 0)
            {
                throw new Exception("Ürün fiyatı 0'dan büyük olmalıdır.");
            }

            // Eğer iş kuralları geçerse, ürünü veritabanına ekle
            _productDal.Add(product);
        } 
    }
}
