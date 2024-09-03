using CORE.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CompanyName { get; set; }
        public List<Order> Orders { get; set; } // Müşteriye ait siparişler
    }
}
