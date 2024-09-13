using CORE;
using CORE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    // İlk olarak : IDto yazdığımda ınterface olarak bulunmadığı için hata vermişti ben de sağ tık refactoring ile new generict oluşturdum açılan ekranda ınteface se.tim hangi katmanda olacağını vs seçip sonra hangi klasörde olacağını seçerek oluşturdum .
    public class ProductDetailDto : IDto

    {
        public int ProductId { get; set; }          // Ürün ID'si
        public string ProductName { get; set; }     // Ürün Adı
        public string CategoryName { get; set; }    // Kategori Adı
        public decimal UnitPrice { get; set; }      // Birim Fiyat
        public short UnitInStock { get; set; }      // Stoktaki Miktar
        public string CustomerName { get; set; }    // Müşteri Adı
        public string FarmerFullName { get; set; }      // Çiftçi Adı
        public DateTime OrderDate { get; set; }     // Sipariş Tarihi
    }
}
  