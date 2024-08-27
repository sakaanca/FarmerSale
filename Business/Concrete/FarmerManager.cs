using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FarmerManager : IFarmerService
    {
        IFarmerDal _farmerdal; // veri erişimi için bu işlem yapılıyor bu yapılmazsa veri erişimi olmaz.
        
    }
}
