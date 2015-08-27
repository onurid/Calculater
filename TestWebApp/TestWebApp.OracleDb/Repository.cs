using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TestWebApp.Domain.Core;

namespace TestWebApp.OracleDb
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
