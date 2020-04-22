using System.Linq;
using Microsoft.EntityFrameworkCore;
using SmartSkinCare.DAL.Contexts;

namespace SmartSkinCare.DAL.Repositories
{
    public abstract class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : class
    {
        protected readonly SkinCareDbContext Context;

        protected BaseRepository(SkinCareDbContext context)
        {
            Context = context;
        }

        public virtual IQueryable<TEntity> Get()
            => Context.Set<TEntity>();

        public virtual TEntity GetByKey(TKey key)
            => Context.Find<TEntity>(key);

        public virtual void Insert(TEntity entity)
            => Context.Set<TEntity>().Add(entity);

        public virtual void Remove(TKey key)
        {
            TEntity entity = GetByKey(key);
            Context.Set<TEntity>().Remove(entity);
        }

        public virtual void Update(TEntity entity)
            => Context.Entry(entity).State = EntityState.Modified;

        public virtual void Save()
            => Context.SaveChanges();
    }
}