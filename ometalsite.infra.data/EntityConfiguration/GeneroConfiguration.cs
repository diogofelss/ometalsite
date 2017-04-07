using ometalsite.domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ometalsite.infra.data.EntityConfiguration
{
    public class GeneroConfiguration : EntityTypeConfiguration<Genero>
    {
        public GeneroConfiguration()
        {
            HasKey(c => c.GeneroId);

            Property(c => c.Nomeclatura).IsRequired().HasMaxLength(100);
        }
    }
}
