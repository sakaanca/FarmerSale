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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, FarmerContext>, ICustomerDal
    {
        // EfEntityRepositoryBase sınıfından miras alınan temel CRUD işlemleri burada sağlanır.
        // Eğer özel sorgular veya metotlar eklemek isterseniz, buraya ekleyebilirsiniz.
        public void AddCustomer(Customer customer)
        {
            using (var context = new FarmerContext())
            {
                context.Customers.Add(customer);  // Yeni müşteri ekle
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }
        public List<Customer> GetAllCustomers()
        {
            using (var context = new FarmerContext())
            {
                return context.Customers.ToList();  // Tüm müşterileri getir
            }
        }
        public Customer GetCustomerById(int customerId)
        {
            using (var context = new FarmerContext())
            {
                return context.Customers.FirstOrDefault(c => c.CustomerId == customerId);  // Id'ye göre müşteri getir
            }
        }
        public void UpdateCustomer(Customer customer)
        {
            using (var context = new FarmerContext())
            {
                context.Customers.Update(customer);  // Müşteriyi güncelle
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }
        public void DeleteCustomer(Customer customer)
        {
            using (var context = new FarmerContext())
            {
                context.Customers.Remove(customer);  // Müşteriyi sil
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }





    }
}
