using System.Collections.Generic;
using ometalsite.domain.Entities;
using ometalsite.domain.Interfaces.Common;

namespace ometalsite.domain.Interfaces
{
    public interface IBandaRepository : IRepositoryBase<Banda>
    {
        IEnumerable<Banda> GetBandasByGenero(int generoId);
    }
}