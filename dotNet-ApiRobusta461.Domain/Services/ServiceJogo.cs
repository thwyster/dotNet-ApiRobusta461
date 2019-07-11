using dotNet_ApiRobusta461.Domain.Arguments.Base;
using dotNet_ApiRobusta461.Domain.Arguments.Jogo;
using dotNet_ApiRobusta461.Domain.Entities;
using dotNet_ApiRobusta461.Domain.Interfaces.Repositories;
using dotNet_ApiRobusta461.Domain.Interfaces.Services;
using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dotNet_ApiRobusta461.Domain.Services
{
    public class ServiceJogo : Notifiable, IServiceJogo
    {
        private readonly IRepositoryJogo _repositoryJogo;

        protected ServiceJogo()
        {

        }

        public ServiceJogo(IRepositoryJogo repositoryJogo)
        {
            _repositoryJogo = repositoryJogo;
        }

        public AdicionarJogoResponse AdicionarJogo(AdicionarJogoRequest request)
        {
            if (request == null)
            {
                AddNotification("AdicionarRequest", "Request nula");
                return null;
            }

            var jogo = new Jogo(request.Nome, request.Descricao, request.Produtora, request.Distribuidora, request.Genero, request.Site);

            AddNotifications(jogo);

            if (this.IsInvalid())
                return null;

            jogo = _repositoryJogo.Adicionar(jogo);

            return (AdicionarJogoResponse)jogo;
        }

        public ResponseBase AlterarJogo(AlterarJogoRequest request)
        {
            if (request == null)
            {
                AddNotification("AlterarRequest", "Request nula");
                return null;
            }

            var jogo = _repositoryJogo.ObterPorId(request.Id);

            if (jogo == null)
                AddNotification("Id", "Dados não encontrado");

            jogo.Alterar(request.Nome, request.Descricao, request.Produtora, request.Distribuidora, request.Genero, request.Site);

            if (IsInvalid())
                return null;

            _repositoryJogo.Editar(jogo);

            return (ResponseBase)jogo;
        }

        public ResponseBase ExcluirJogo(Guid id)
        {
            if (id == null)
            {
                AddNotification("id", "Id nula");
                return null;
            }

            var jogo = _repositoryJogo.ObterPorId(id);

            if (jogo == null)
                AddNotification("Id", "Dados não encontrado");

            _repositoryJogo.Remover(jogo);

            return new ResponseBase() { Message = "Operacao realizada com sucesso"};
        }

        public IEnumerable<JogoResponse> ListarJogo()
        {
            return _repositoryJogo.Listar().ToList().Select(jogo => (JogoResponse)jogo).ToList();
        }
    }
}
