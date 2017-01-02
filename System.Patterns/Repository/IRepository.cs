using System.Linq;

namespace System.Patterns.Repository
{
    public interface IRepository<TEntity, TKey>
    {
        IQueryable<TEntity> GetAll();

        TEntity Get(TKey id);

        void Update(TEntity entity);

        void Remove(TEntity entity);

        void Add(TEntity entity);
    }

    public interface IRepository<TEntity> : IRepository<TEntity, int>
    {
    }
}
