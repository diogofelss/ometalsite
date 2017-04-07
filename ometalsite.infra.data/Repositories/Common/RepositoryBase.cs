using System;
using System.Data.Entity;
using System.Linq;
using ometalsite.domain.Interfaces.Common;
using ometalsite.infra.data.Context;

namespace ometalsite.infra.data.Repositories.Common
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ometalsiteContext DBContext = new ometalsiteContext();

        public void Dispose()
        {
            DBContext.Dispose();
        }

        public void Add(TEntity T)
        {
            DBContext.Set<TEntity>().Add(T);
            DBContext.SaveChanges();
        }

        public void Update(TEntity T)
        {
            DBContext.Entry(T).State = EntityState.Modified;
            DBContext.SaveChanges();
        }

        public void Remove(TEntity T)
        {
            DBContext.Set<TEntity>().Remove(T);
            DBContext.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return DBContext.Set<TEntity>().Find(id);
        }

        public System.Collections.Generic.IEnumerable<TEntity> GetAll()
        {
            return DBContext.Set<TEntity>().ToList();
        }
    }
}
