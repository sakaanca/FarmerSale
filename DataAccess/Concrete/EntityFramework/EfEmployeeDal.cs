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
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, FarmerContext>, IEmployeeDal
    {        // Burada özel sorgular/metotlar gerekiyorsa buraya eklenebilir
        public void AddEmployee(Employee employee)
        {
            using (var context = new FarmerContext())
            {
                context.Employees.Add(employee);  // Yeni çalışanı ekle
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }
        public List<Employee> GetAllEmployees()
        {
            using (var context = new FarmerContext())
            {
                return context.Employees.ToList();  // Tüm çalışanları getir
            }
        }
        public Employee GetEmployeeById(int employeeId)
        {
            using (var context = new FarmerContext())
            {
                return context.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);  // Id'ye göre çalışan getir
            }
        }
        public void UpdateEmployee(Employee employee)
        {
            using (var context = new FarmerContext())
            {
                context.Employees.Update(employee);  // Çalışanı güncelle
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }
        public void DeleteEmployee(Employee employee)
        {
            using (var context = new FarmerContext())
            {
                context.Employees.Remove(employee);  // Çalışanı sil
                context.SaveChanges();  // Değişiklikleri veritabanına kaydet
            }
        }


    }
}
