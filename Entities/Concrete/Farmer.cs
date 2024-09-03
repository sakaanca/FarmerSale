using CORE.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Farmer : IEntity
    {
        public int FarmerId { get; set; }
        public string FarmerFullName { get; set; }
        public string FarmerAddress { get; set; }
        public List<Product> Products { get; set; } // Çiftçiye ait ürünler
        public List<Order> Orders { get; set; } // Çiftçinin siparişleri
    }
}
