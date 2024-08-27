using Entities.Abstract;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
       
    }
}
