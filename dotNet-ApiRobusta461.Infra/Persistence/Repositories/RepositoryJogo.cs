
using dotNet_ApiRobusta461.Domain.Entities;
using dotNet_ApiRobusta461.Domain.Interfaces.Repositories;
using dotNet_ApiRobusta461.Infra.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace dotNet_ApiRobusta461.Infra.Persistence.Repositories
{
    public class RepositoryJogo : RepositoryBase<Jogo, Guid>, IRepositoryJogo
    {
        protected readonly MeuContext _context;

        public RepositoryJogo(MeuContext context) : base(context)
        {
            _context = context;
        }

        public Jogador Adicionar(Jogador entidade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jogador> AdicionarLista(IEnumerable<Jogador> entidades)
        {
            throw new NotImplementedException();
        }

        public Jogador Editar(Jogador entidade)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Func<Jogador, bool> where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Jogador> Listar(params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Jogador> ListarEOrdenadosPor<TKey>(Expression<Func<Jogador, bool>> where, Expression<Func<Jogador, TKey>> ordem, bool ascendente = true, params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Jogador> ListarOrdenadosPor<TKey>(Expression<Func<Jogador, TKey>> ordem, bool ascendente = true, params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Jogador> ListarPor(Expression<Func<Jogador, bool>> where, params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Jogador ObterPor(Func<Jogador, bool> where, params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Jogador ObterPorId(Guid id, params Expression<Func<Jogador, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public void Remover(Jogador entidade)
        {
            throw new NotImplementedException();
        }
    }
}
