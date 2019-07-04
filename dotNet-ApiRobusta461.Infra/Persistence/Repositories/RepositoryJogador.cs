using dotNet_ApiRobusta461.Domain.Entities;
using dotNet_ApiRobusta461.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dotNet_ApiRobusta461.Infra.Persistence.Repositories
{
    public class RepositoryJogador : IRepositoryJogador
    {
        protected readonly MeuContext _context;

        public RepositoryJogador(MeuContext context)
        {
            _context = context;
        }

        public Jogador AdicionarJogador(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();

            return jogador;
        }

        public void AlterarJogador(Jogador jogador)
        {
            throw new NotImplementedException();
        }

        public Jogador AutenticarJogador(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jogador> ListarJogador()
        {
            return _context.Jogadores.ToList();
        }

        public Jogador ObterJogadorPorId(Guid id)
        {
            return _context.Jogadores.Where(w => w.Id == id).FirstOrDefault();
        }
    }
}
