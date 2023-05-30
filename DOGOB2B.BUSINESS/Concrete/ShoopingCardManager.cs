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
    public class ShoopingCardManager : IShoppingCardService
    {

        private readonly IShoppingCardItemDal _shoppingDal;

        public ShoopingCardManager(IShoppingCardItemDal shoppingDal)
        {
            this._shoppingDal = shoppingDal;
        }
        public async Task Add(ShoppingCardItem entity)
        {
            await _shoppingDal.Add(entity);
        }

        public Task AddToCard(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task ClearCard()
        {
            throw new NotImplementedException();
        }

        public async Task Delete(ShoppingCardItem entity)
        {
           await _shoppingDal.Delete(entity);
        }

        public async Task<ShoppingCardItem>? Get(Expression<Func<ShoppingCardItem, bool>> filter)
        {
            return await _shoppingDal.Get(filter);
        
        }

        public async Task<List<ShoppingCardItem>> GetShoppingCardItems(Expression<Func<ShoppingCardItem, bool>> filter = null)
        {
            if (filter == null)
                return await _shoppingDal.GetAll();
            else return await _shoppingDal.GetAll(filter);
        }

        public Task<decimal> GetShoppingCardTotal()
        {
            throw new NotImplementedException();
        }

        public Task<int> RemoveFromCard(Product card)
        {
            throw new NotImplementedException();
        }

        public async Task Update(ShoppingCardItem entity)
        {
            await _shoppingDal.Update(entity);
        }
    }
}
