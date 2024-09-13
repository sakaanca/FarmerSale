using CORE.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {// ÜRÜNE DAİR ÖZEL OPERASYONLAR BURADA YAPILIR
     //IEntityRepository producta göre yapılandırdım .
        List<ProductDetailDto> GetProductDetails();

    }
}
