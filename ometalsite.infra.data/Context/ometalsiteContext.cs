using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using ometalsite.domain.Entities;
using ometalsite.infra.data.EntityConfiguration;

namespace ometalsite.infra.data.Context
{
    public class ometalsiteContext : DbContext
    {
        public ometalsiteContext() : base("ometalsiteconnectionstring")
        {

        }

        #region DBSet

        public DbSet<Genero> CAD_GENERO { get; set; }
        public DbSet<Banda> CAD_BANDA { get; set; }

        #endregion

        #region Métodos sobescritos

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(c => c.Name == c.ReflectedType + "Id").Configure(c => c.IsKey());
            modelBuilder.Properties<string>().Configure(a => a.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(a => a.HasMaxLength(255));

            modelBuilder.Configurations.Add(new GeneroConfiguration());
            modelBuilder.Configurations.Add(new BandaConfiguration());
        }

        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }

            return base.SaveChanges();
        }

        #endregion
    }
}
