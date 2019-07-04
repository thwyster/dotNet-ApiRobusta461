using dotNet_ApiRobusta461.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace dotNet_ApiRobusta461.Infra.Persistence.Map
{
    public class MapJogador : EntityTypeConfiguration<Jogador>
    {
        public MapJogador()
        {
            //Importante caso se use mnemonicos no banco
            ToTable("Jogador");

            Property(w => w.Email.Endereco).HasMaxLength(200).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_JOGADOR_EMAIL") { IsUnique = true })).HasColumnName("Email");
            Property(w => w.Nome.PrimeiroNome).HasMaxLength(50).IsRequired().HasColumnName("PrimeiroNome");
            Property(w => w.Nome.UltimoNome).HasMaxLength(50).IsRequired().HasColumnName("UltimoNome");
            Property(w => w.Senha).IsRequired();
            Property(w => w.Status).IsRequired();
        }
    }
}
