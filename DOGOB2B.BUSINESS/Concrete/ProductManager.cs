using DOGOB2B.BUSINESS.Abstract;
using DOGOB2B.DATAACCESS.Abstract;
using DOGOB2B.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOGOB2B.BUSINESS.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            this._productDal = productDal;
        }
        public async Task Add(Product entity)
        {
           await _productDal.Add(entity);
        }

        public async Task Delete(Product entity)
        {
            await _productDal.Delete(entity);
        }

        public async Task<Product>? Get(Expression<Func<Product, bool>> filter)
        {
            return await _productDal.Get(filter);
        }

        public async Task<List<Product>> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return await _productDal.GetAll(filter);
        }

        public async Task Update(Product entity)
        {
          await _productDal.Update(entity);
        }
    }
}
