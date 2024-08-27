using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{// Burada entitiyframework kodlarımızı yazacağız.
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (FarmerContext context = new FarmerContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (FarmerContext context = new FarmerContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }





        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (FarmerContext context = new  FarmerContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
                

            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (FarmerContext context = new FarmerContext())
            {
                 return filter == null
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();

            }
        }




        public void Update(Product entity)
        {
            using (FarmerContext context = new FarmerContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
