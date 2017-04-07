using System.Collections;
using System.Collections.Generic;

namespace ometalsite.domain.Interfaces.Common
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity T);

        void Update(TEntity T);

        void Remove(TEntity T);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Dispose();
    }
}
