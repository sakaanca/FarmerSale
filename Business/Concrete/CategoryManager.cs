﻿using Business.Abstract;
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
    public class CategoryManager : ICategoryService
        // Manager sınıfında  iş kodlarımızı yazıyoruz . 
    {
        ICategoryDal _categoryDal;

     
    }
}
