using CORE.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{// Burada entitiyframework kodlarımızı yazacağız.
    public class EfProductDal :EfEntityRepositoryBase<Product , FarmerContext>, IProductDal
    {
       
    }
}
