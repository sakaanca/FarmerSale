using Entities.Abstract;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    //generic constrait
    //class : referans tip
    //IEntity : IEntitiy olabilir veya IEntitiy implamante den bir sınıf 
    public interface IEntityRepository<T> where T : class, IEntity, new()//Böylelilkle T değeri bir class olmak zorunda ve bu class da IEntitiy ile implamente eddilmek zorunda ve ek olarak new lenebilir olmalı..
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);// Ürünleri filtrelememizi sağlıyor bu kod. 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
     
    }
}
