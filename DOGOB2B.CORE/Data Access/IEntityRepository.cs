using DOGOB2B.ENTITY.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOGOB2B.CORE.Data_Access
{
    public interface IEntityRepository<TEntity> where TEntity : class,IEntity,new()
    {
      Task Add(TEntity entity);
      Task Update(TEntity entity);
       Task  Delete(TEntity entity);

        Task< TEntity> ? Get(Expression<Func<TEntity,bool>> filter);

       Task< List< TEntity>> GetAll(Expression<Func<TEntity, bool>> filter=null);

    }
}
