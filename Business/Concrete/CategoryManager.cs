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
{// Burada service kodlarını implamente ederek dış dünyaya açarız ve iş kdlarını burada yazarız
    public class CategoryManager : ICategoryService
        // Manager sınıfında  iş kodlarımızı yazıyoruz . 
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
        //iş kodları
        return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            //iş kodları örneğin (  select* from categories where cotegoriıd =3 ) gibi
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }

       
    }
}
