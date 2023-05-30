using DOGOB2B.ENTITY.Abstract;
using DOGOB2B.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOGOB2B.BUSINESS.Abstract
{
   public  interface IProductService
    {
        Task Add(Product entity);
        Task Update(Product entity);
        Task Delete(Product entity);
        Task<Product>? Get(Expression<Func<Product, bool>> filter);
        Task<List<Product>> GetAll(Expression<Func<Product, bool>> filter = null);

    }
}
