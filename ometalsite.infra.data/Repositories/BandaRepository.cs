using System.Collections.Generic;
using System.Linq;
using ometalsite.domain.Entities;
using ometalsite.domain.Interfaces;
using ometalsite.infra.data.Repositories.Common;

namespace ometalsite.infra.data.Repositories
{
    public class BandaRepository : RepositoryBase<Banda>, IBandaRepository
    {
        public IEnumerable<Banda> GetBandasByGenero(int generoId)
        {
            return DBContext.CAD_BANDA.Where(c => c.GeneroId == generoId).ToList();
        }
    }
}
