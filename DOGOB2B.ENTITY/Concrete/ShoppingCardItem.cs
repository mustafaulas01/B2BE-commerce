using DOGOB2B.ENTITY.Abstract;
using DOGOB2B.ENTITY.Concrete;

namespace DOGOB2B.ENTITY.Concrete
{
    public class ShoppingCardItem:IEntity
    {
        public int Id { get; set; }
        public Product? Product { get; set; }
        public int Qty { get; set; }
        public string ? ShoppingCartId { get; set; }
    }
}
