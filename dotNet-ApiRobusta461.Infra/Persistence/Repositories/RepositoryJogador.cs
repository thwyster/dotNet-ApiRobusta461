
using dotNet_ApiRobusta461.Domain.Entities;
using dotNet_ApiRobusta461.Domain.Interfaces.Repositories;
using dotNet_ApiRobusta461.Infra.Persistence.Repositories.Base;
using System;

namespace dotNet_ApiRobusta461.Infra.Persistence.Repositories
{
    public class RepositoryJogador : RepositoryBase<Jogador, Guid>, IRepositoryJogador
    {
        protected readonly MeuContext _context;

        public RepositoryJogador(MeuContext context) : base(context)
        {
            _context = context;
        }
    }
}
