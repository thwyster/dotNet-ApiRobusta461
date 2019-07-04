using dotNet_ApiRobusta461.Domain.Arguments.Jogador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request);
        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);
        AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request);
        IEnumerable<JogadorResponse> ListarJogador();
    }
}
