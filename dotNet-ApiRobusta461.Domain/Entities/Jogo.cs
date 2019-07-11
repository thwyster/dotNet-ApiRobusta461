using dotNet_ApiRobusta461.Domain.Entities.Base;
using prmToolkit.NotificationPattern;
using System;

namespace dotNet_ApiRobusta461.Domain.Entities
{
    public class Jogo : EntityBase
    {
        protected Jogo()
        {

        }

        public Jogo(string nome, string descricao, string produtora, string distribuidora, string genero, string site)
        {
            Nome = nome;
            Descricao = descricao;
            Produtora = produtora;
            Distribuidora = distribuidora;
            Genero = genero;
            Site = site;

            ValidarEntidade();
        }

        private void ValidarEntidade()
        {
            new AddNotifications<Jogo>(this)
                .IfNullOrInvalidLength(w => w.Nome, 3, 100, "O nome deve ter de 3 a 100 caracteres")
                .IfNullOrInvalidLength(w => w.Descricao, 3, 255, "O descrição deve ter de 3 a 255 caracteres")
                .IfNullOrInvalidLength(w => w.Genero, 3, 30, "O genero deve ter de 3 a 30 caracteres");
        }

        public void Alterar(string nome, string descricao, string produtora, string distribuidora, string genero, string site)
        {
            Nome = nome;
            Descricao = descricao;
            Produtora = produtora;
            Distribuidora = distribuidora;
            Genero = genero;
            Site = site;

            ValidarEntidade();
        }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public string Produtora { get; private set; }
        public string Distribuidora { get; private set; }
        public string Genero { get; private set; }
        public string Site { get; private set; }
    }
}
