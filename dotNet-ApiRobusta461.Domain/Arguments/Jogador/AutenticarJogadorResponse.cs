using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Domain.Arguments.Jogador
{
    public class AutenticarJogadorResponse
    {
        public string Email { get; set; }
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; internal set; }

        public static explicit operator AutenticarJogadorResponse(Entities.Jogador jogador)
        {
            return new AutenticarJogadorResponse()
            {
                Email = jogador.Email.Endereco,
                PrimeiroNome = jogador.Nome.PrimeiroNome,
                SegundoNome = jogador.Nome.UltimoNome
            };
        }
    }
}
