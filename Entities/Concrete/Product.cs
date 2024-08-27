using Entities.Abstract;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } // Ürünün kategorisi
        public short UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public DateTime ProductionDate { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } // Ürünün siparişi
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } // Ürünün müşterisi
        public int FarmerId { get; set; }
        public Farmer Farmer { get; set; } // Ürünün çiftçisi
    }
}
