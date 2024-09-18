using CORE.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {        // Eğer çalışana dair özel operasyonlar gerekiyorsa buraya eklenebilir

    }
}
