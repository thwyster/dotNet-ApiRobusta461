using dotNet_ApiRobusta461.Domain.Entities;
using dotNet_ApiRobusta461.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador : IRepositoryBase<Jogador, Guid>
    {
    }
}
