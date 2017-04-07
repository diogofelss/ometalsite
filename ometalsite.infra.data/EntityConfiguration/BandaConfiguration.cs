using ometalsite.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ometalsite.infra.data.EntityConfiguration
{
    public class BandaConfiguration : EntityTypeConfiguration<Banda>
    {
        public BandaConfiguration()
        {
            HasKey(b => b.BandaId);

            Property(b => b.Nome).IsRequired();
            Property(b => b.GeneroId).IsRequired();

            HasRequired(c => c.Genero)
                    .WithMany()
                    .HasForeignKey(b => b.GeneroId);
        }
    }
}
