using CORE.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICategoryDal :IEntityRepository<Category>
    {
        Category GetCategoryByName(string categoryName);
    }
}
