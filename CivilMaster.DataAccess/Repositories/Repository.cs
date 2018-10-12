using CivilMater.Domain.Entities;
using CivilMater.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CivilMaster.DataAccess.Repositories
{
    public class Repository<E> : IRepository<E>, IUnityOfWork where E : Entity
    {
        protected CivilMasterContext context;

        public Repository(CivilMasterContext context)
        {
            this.context = context;
        }

        public void Commit()
        {
            this.context.SaveChanges();
        }

        public ICollection<E> Find(Expression<Func<E, bool>> expression)
        {
            return context.Set<E>().Where(expression).ToList();
        }

        public void Remove(E entity)
        {
             context.Set<E>().Remove(entity);
        }

        public void Save(E entity)
        {
            entity.CreateId();
            context.Set<E>().Add(entity);
        }


    }
}
