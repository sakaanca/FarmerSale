using CORE.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {// ÜRÜNE DAİR ÖZEL OPERASYONLAR BURADA YAPILIR
 //IEntityRepository producta göre yapılandırdım .

    }
}
