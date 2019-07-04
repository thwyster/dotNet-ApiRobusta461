using dotNet_ApiRobusta461.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace dotNet_ApiRobusta461.Infra.Persistence.Map
{
    public class MapPlataforma : EntityTypeConfiguration<Plataforma>
    {
        public MapPlataforma()
        {
            //Importante caso se use mnemonicos no banco
            ToTable("Plataforma");

            Property(w => w.Nome).HasMaxLength(50).IsRequired();
        }
    }
}
