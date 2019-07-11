using dotNet_ApiRobusta461.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace dotNet_ApiRobusta461.Infra.Persistence.Map
{
    public class MapJogo : EntityTypeConfiguration<Jogo>
    {
        public MapJogo()
        {
            //Importante caso se use mnemonicos no banco
            ToTable("Jogo");

            Property(w => w.Nome).HasMaxLength(100).IsRequired();
            Property(w => w.Descricao).HasMaxLength(255).IsRequired();
            Property(w => w.Produtora).HasMaxLength(50);
            Property(w => w.Distribuidora).HasMaxLength(50);
            Property(w => w.Genero).HasMaxLength(50);
            Property(w => w.Site).HasMaxLength(200);
        }
    }
}
