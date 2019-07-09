using dotNet_ApiRobusta461.Domain.Arguments.Base;
using dotNet_ApiRobusta461.Domain.Arguments.Jogador;
using dotNet_ApiRobusta461.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Domain.Interfaces.Services
{
    public interface IServiceJogador : IServiceBase
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
        AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request);
        IEnumerable<JogadorResponse> ListarJogador();
        ResponseBase ExcluirJogador(Guid Id);
    }
}
