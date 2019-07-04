using dotNet_ApiRobusta461.Domain.Arguments.Jogador;
using dotNet_ApiRobusta461.Domain.Arguments.Plataforma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Domain.Interfaces.Services
{
    public interface IServicePlataforma
    {
        AdicionarPlataformaResponse AdicionarPlataforma(AdicionarJogadorRequest request);
    }
}
