using dotNet_ApiRobusta461.Domain.Arguments.Base;
using dotNet_ApiRobusta461.Domain.Arguments.Jogo;
using dotNet_ApiRobusta461.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace dotNet_ApiRobusta461.Domain.Interfaces.Services
{
    public interface IServiceJogo : IServiceBase
    {
        IEnumerable<JogoResponse> ListarJogo();

        AdicionarJogoResponse AdicionarJogo(AdicionarJogoRequest request);

        ResponseBase AlterarJogo(AlterarJogoRequest request);

        ResponseBase ExcluirJogo(Guid id);


    }
}

