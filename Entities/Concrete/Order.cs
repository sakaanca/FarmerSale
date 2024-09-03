using CORE.Entities;


namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } // Siparişi veren müşteri
        public int FarmerId { get; set; }
        public Farmer Farmer { get; set; } // Siparişin çiftçisi
        public List<Product> Products { get; set; } // Siparişe ait ürünler
    }
}
