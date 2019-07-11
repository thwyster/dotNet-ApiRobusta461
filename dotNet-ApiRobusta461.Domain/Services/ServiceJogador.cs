using dotNet_ApiRobusta461.Domain.Arguments.Base;
using dotNet_ApiRobusta461.Domain.Arguments.Jogador;
using dotNet_ApiRobusta461.Domain.Entities;
using dotNet_ApiRobusta461.Domain.Interfaces.Repositories;
using dotNet_ApiRobusta461.Domain.Interfaces.Services;
using dotNet_ApiRobusta461.Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador()
        {

        }

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            Nome nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            Email email = new Email(request.Email);
            Jogador jogador = new Jogador(nome, email, request.Senha);

            AddNotifications(nome, email);

            if (_repositoryJogador.Existe(w => w.Email.Endereco == request.Email))
                AddNotification("Email", "Email já existente");

            if (this.IsInvalid())
                return null;

            jogador = _repositoryJogador.Adicionar(jogador);

            return (AdicionarJogadorResponse)jogador;
        }

        public AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarJogadorRequest", "é obrigatorio");
            }

            Jogador jogador = _repositoryJogador.ObterPorId(request.Id);

            if (jogador == null)
            {
                AddNotification("Id", "Jogador não foi encontrado");
                return null;
            }

            Nome nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            Email email = new Email(request.Email);

            jogador.AlterarJogador(nome, email, jogador.Status);

            AddNotifications(jogador);

            if (this.IsInvalid())
                return null;

            _repositoryJogador.Editar(jogador);

            return (AlterarJogadorResponse)jogador;
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarJogadorRequest", "é obrigatorio");
            }

            var email = new Email(request.Email);
            var jogador = new Jogador(email, request.Senha);

            AddNotifications(jogador, email);

            if (jogador.IsInvalid())
                return null;

            jogador = _repositoryJogador.ObterPor(w => w.Email.Endereco == jogador.Email.Endereco && w.Senha == jogador.Senha);


            return (AutenticarJogadorResponse)jogador;
        }

        public IEnumerable<JogadorResponse> ListarJogador()
        {
            //return _repositoryJogador.Listar().Select(jogador => (JogadorResponse)jogador).ToList();
            return _repositoryJogador.Listar().ToList().Select(jogador => (JogadorResponse)jogador).ToList();
        }

        public ResponseBase ExcluirJogador(Guid Id)
        {
            Jogador jogador = _repositoryJogador.ObterPorId(Id);

            if (jogador == null)
            {
                AddNotification("Id", "Jogador não encontrados");
                return null;
            }

            _repositoryJogador.Remover(jogador);

            return new ResponseBase();
        }
    }
}
