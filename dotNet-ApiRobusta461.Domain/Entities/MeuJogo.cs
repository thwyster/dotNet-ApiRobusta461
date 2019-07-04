using System;

namespace dotNet_ApiRobusta461.Domain.Entities
{
    public class MeuJogo
    {
        public Guid Id { get; set; }
        public JogoPlataforma JogoPlataforma { get; set; }
        public bool Desejo { get; set; }
        public bool Troco { get; set; }
        public bool Vendo { get; set; }
        public DateTime DataDesejo { get; set; }
    }
}
