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
            Nome nome = new Nome(request.PrimeiroNome, request.Senha);
            Email email = new Email(request.Email);
            Jogador jogador = new Jogador(nome, email, request.Senha);

            if (this.IsInvalid())
                return null;

            jogador = _repositoryJogador.AdicionarJogador(jogador);

            return (AdicionarJogadorResponse)jogador;
        }

        public AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarJogadorRequest", "é obrigatorio");
            }

            Jogador jogador = _repositoryJogador.ObterJogadorPorId(request.Id);

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

            _repositoryJogador.AlterarJogador(jogador);

            return (AlterarJogadorResponse)jogador;
        }

        public AutenticarJogadorResponse AutenticarJogador(AutenticarJogadorRequest request)
        {
            if (request == null)
            {
                AddNotification("AutenticarJogadorRequest", "é obrigatorio");
            }

            var email = new Email(request.Email);
            var jogador = new Jogador(email, "222");

            AddNotifications(jogador, email);

            if (jogador.IsInvalid())
                return null;

            jogador = _repositoryJogador.AutenticarJogador(request.Email, request.Senha);


            return (AutenticarJogadorResponse)jogador;
        }

        public IEnumerable<JogadorResponse> ListarJogador()
        {
            return _repositoryJogador.ListarJogador().Select(jogador => (JogadorResponse)jogador).ToList();
        }
    }
}
