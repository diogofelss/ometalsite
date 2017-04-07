namespace ometalsite.domain.Entities
{
    public class Banda
    {
        public int BandaId { get; set; }
        public string Nome { get; set; }
        public int GeneroId { get; set; }

        public virtual Genero Genero { get; set; }
    }
}
