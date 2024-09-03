using CORE.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
 //IEntityRepository producta göre yapılandırdım .

    }
}
