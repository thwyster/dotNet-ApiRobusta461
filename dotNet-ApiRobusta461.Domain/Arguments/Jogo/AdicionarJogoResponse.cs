using System;
using dotNet_ApiRobusta461.Domain.Entities;

namespace dotNet_ApiRobusta461.Domain.Arguments.Jogo
{
    public class AdicionarJogoResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }

        public static explicit operator AdicionarJogoResponse(Entities.Jogo entidade)
        {
            return new AdicionarJogoResponse()
            {
                Id = entidade.Id,
                Message = "Operação realizada com Sucesso"
            };
        }
    }
}
