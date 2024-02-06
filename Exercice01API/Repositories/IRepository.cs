using System.Linq.Expressions;

namespace Exercice01API.Repositories
{
    public interface IRepository<TEntity>
    {
        bool Add(TEntity task);
        TEntity? GetById(int id);
        TEntity? Get(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        bool Update(TEntity task);
        bool Delete(int id);
    }
}
