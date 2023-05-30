using DOGOB2B.CORE.Data_Access;
using DOGOB2B.ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOGOB2B.DATAACCESS.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
