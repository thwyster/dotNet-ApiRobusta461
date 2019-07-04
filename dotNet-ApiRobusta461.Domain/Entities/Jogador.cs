using dotNet_ApiRobusta461.Domain.Enum;
using dotNet_ApiRobusta461.Domain.Extensions;
using dotNet_ApiRobusta461.Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using System;

namespace dotNet_ApiRobusta461.Domain.Entities
{
    public class Jogador : Notifiable
    {
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(w => w.Senha, 6, 32, "A senha deve ter pelo menos 6 a 32 caracteres");
        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Id = Guid.NewGuid();
            Status = StatusJogador.EmAnalise;

            new AddNotifications<Jogador>(this)
                .IfNullOrInvalidLength(w => w.Senha, 6, 32, "A senha deve ter pelo menos 6 a 32 caracteres");

            if (IsValid())
                Senha = Senha.ConvertToMD5();

            AddNotifications(nome, email);
        }

        public void AlterarJogador(Nome nome, Email email, StatusJogador status)
        {
            Nome = nome;
            Email = email;

            if (status != StatusJogador.Ativo)
                AddNotification("Jogador", "Não é possivel alterar jogadores nao ativos");

            AddNotifications(nome, email);
        }

        public Guid Id { get; private set; }
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public StatusJogador Status { get; private set; }
    }
}
