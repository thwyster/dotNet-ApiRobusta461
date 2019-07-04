using dotNet_ApiRobusta461.Domain.Interfaces.Arguments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AdicionarJogadorResponse(Entities.Jogador jogador)
        {
            return new AdicionarJogadorResponse()
            {
                Id = jogador.Id,
                Message = "Operação realizada com sucesso"
            };
        }
    }
}
