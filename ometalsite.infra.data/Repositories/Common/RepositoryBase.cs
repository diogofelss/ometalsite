using ometalsite.domain.Interfaces.Common;
using System;
namespace ometalsite.infra.data.Repositories.Common
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        public void Dispose()
        {
            
        }

        public void Add(TEntity T)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity T)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity T)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public System.Collections.Generic.IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
