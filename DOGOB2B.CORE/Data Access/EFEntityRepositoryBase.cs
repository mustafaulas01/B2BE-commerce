using DOGOB2B.ENTITY.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOGOB2B.CORE.Data_Access
{
    public class EFEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task  Add(TEntity entity)
        {
            using (var context=new TContext())
            {
                var addedEntity=  context.Entry(entity);
                addedEntity.State = EntityState.Added;

              await  context.SaveChangesAsync();

            }

             
        }

        public async Task Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;

               await context.SaveChangesAsync();

            }
        }

        public async Task< TEntity> ? Get(Expression<Func<TEntity, bool>> filter)
        {
            using ( var context=new TContext())
            {
           

                return await context.Set<TEntity>().SingleOrDefaultAsync(filter);

            }
        }

        public async Task< List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
               if(filter==null)
                    return await context.Set<TEntity>().ToListAsync();
                else
                    return await context.Set<TEntity>().Where(filter).ToListAsync();

             
            }
        }

        public async Task  Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;

               await context.SaveChangesAsync();

            }
        }
    }
}
