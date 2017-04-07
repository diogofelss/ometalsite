using System.Collections.Generic;

namespace ometalsite.domain.Entities
{
    public class Genero
    {
        public int GeneroId { get; set; }
        public string Nomeclatura { get; set; }
        public int GeneroPaiId { get; set; }
        public virtual IEnumerable<Banda> Bandas { get; set; }

        public bool IsSubGenero(Genero genero)
        {
            return genero.GeneroPaiId > 0;
        }
    }
}
