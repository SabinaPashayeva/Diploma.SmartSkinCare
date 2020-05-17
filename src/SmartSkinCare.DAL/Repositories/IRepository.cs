using System.Linq;

namespace SmartSkinCare.DAL.Repositories
{
    public interface IRepository<TEntity, TKey>
        where TEntity : class
    {
        IQueryable<TEntity> Get();

        TEntity GetByKey(TKey key);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Remove(TKey key);

        void Save();
    }
}
