using dotNet_ApiRobusta461.Domain.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace dotNet_ApiRobusta461.Infra.Persistence
{
    public class MeuContext : DbContext
    {
        public IDbSet<Jogador> Jogadores { get; set; }
        public IDbSet<Plataforma> Plataformas { get; set; }

        public MeuContext() : base("connectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(w => w.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(w => w.HasMaxLength(100));

            modelBuilder.Configurations.AddFromAssembly(typeof(MeuContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
