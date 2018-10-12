using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CivilMater.Domain.Repositories
{
    public interface IRepository<E>
    {
        void Save(E entity);

        void Remove(E entity);

        ICollection<E> Find(Expression<Func<E, bool>> expression);
    }
}
