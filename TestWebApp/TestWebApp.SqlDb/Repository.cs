using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TestWebApp.Domain.Core;

namespace TestWebApp.SqlDb
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        readonly DbContext entities;
        readonly IDbSet<T> dbset;

        public Repository(DbContext context)
        {
            this.entities = context;
            this.dbset = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.AsEnumerable<T>();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return dbset.Where(predicate).AsEnumerable();
        }

        public T Add(T entity)
        {
            return dbset.Add(entity);
        }

        public T Delete(T entity)
        {
            return dbset.Remove(entity);
        }

        public void Edit(T entity)
        {
            entities.Entry(entity).State = EntityState.Modified;
        }

        public void Save()
        {
            entities.SaveChanges();
        }
    }
}
