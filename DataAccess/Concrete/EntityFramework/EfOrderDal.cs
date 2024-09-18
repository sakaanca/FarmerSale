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
    public class EfOrderDal : EfEntityRepositoryBase<Order, FarmerContext>, IOrderDal
    {
        public void AddOrder(Order order)
        {
            using (var context = new FarmerContext())
            {
                context.Orders.Add(order);  // Yeni siparişi ekle
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }
        public List<Order> GetAllOrders()
        {
            using (var context = new FarmerContext())
            {
                return context.Orders.ToList();  // Tüm siparişleri getir
            }
        }
        public Order GetOrderById(int orderId)
        {
            using (var context = new FarmerContext())
            {
                return context.Orders.FirstOrDefault(o => o.OrderId == orderId);  // Id'ye göre sipariş getir
            }
        }
        public void UpdateOrder(Order order)
        {
            using (var context = new FarmerContext())
            {
                context.Orders.Update(order);  // Siparişi güncelle
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }
        public void DeleteOrder(Order order)
        {
            using (var context = new FarmerContext())
            {
                context.Orders.Remove(order);  // Siparişi sil
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }

    }
}
