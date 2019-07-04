using dotNet_ApiRobusta461.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador AutenticarJogador(string email, string senha);
        Jogador AdicionarJogador(Jogador jogador);
        void AlterarJogador(Jogador jogador);
        IEnumerable<Jogador> ListarJogador();
        Jogador ObterJogadorPorId(Guid id);
    }
}
