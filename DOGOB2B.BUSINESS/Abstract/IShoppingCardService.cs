using DOGOB2B.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOGOB2B.BUSINESS.Abstract
{
 public  interface IShoppingCardService
    {

        Task Add(ShoppingCardItem entity);
        Task Update(ShoppingCardItem entity);
        Task Delete(ShoppingCardItem entity);
        Task<ShoppingCardItem>? Get(Expression<Func<ShoppingCardItem, bool>> filter);
        Task<List<ShoppingCardItem>> GetShoppingCardItems(Expression<Func<ShoppingCardItem, bool>> filter = null);

        Task ClearCard();
        Task AddToCard(Product entity);
        Task< int> RemoveFromCard(Product card);

        Task<decimal> GetShoppingCardTotal();
    }
}
