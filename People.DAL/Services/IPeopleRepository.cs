using People.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace People.DAL.Services
{
    public interface IPeopleRepository<TEntity> where TEntity : EntityBase
    {
        void Create(TEntity item);
        TEntity FindById(Guid id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        bool Remove(TEntity item);
        IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties);
        IEnumerable<TEntity> GetWithInclude(Func<TEntity, bool> predicate, params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
