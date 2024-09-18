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
    public class EfFarmerDal : EfEntityRepositoryBase<Farmer, FarmerContext>, IFarmerDal
    {
        public void AddFarmer(Farmer farmer)
        {
            using (var context = new FarmerContext())
            {
                context.Farmers.Add(farmer);  // Yeni çiftçiyi ekle
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }
        public List<Farmer> GetAllFarmers()
        {
            using (var context = new FarmerContext())
            {
                return context.Farmers.ToList();  // Tüm çiftçileri getir
            }
        }
        public Farmer GetFarmerById(int farmerId)
        {
            using (var context = new FarmerContext())
            {
                return context.Farmers.FirstOrDefault(f => f.FarmerId == farmerId);  // Id'ye göre çiftçi getir
            }
        }
        public void UpdateFarmer(Farmer farmer)
        {
            using (var context = new FarmerContext())
            {
                context.Farmers.Update(farmer);  // Çiftçiyi güncelle
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }
        public void DeleteFarmer(Farmer farmer)
        {
            using (var context = new FarmerContext())
            {
                context.Farmers.Remove(farmer);  // Çiftçiyi sil
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }



    }
}
