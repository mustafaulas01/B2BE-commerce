using DOGOB2B.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOGOB2B.BUSINESS.Abstract
{
    public  interface ICategoryService
    {
        Task Add(Category entity);
        Task Update(Category entity);
        Task Delete(Category entity);
        Task<Category>? Get(Expression<Func<Category, bool>> filter);
        Task<List<Category>> GetAll(Expression<Func<Category, bool>> filter = null);
    }
}
