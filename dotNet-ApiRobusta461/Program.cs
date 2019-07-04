using dotNet_ApiRobusta461.Domain.Arguments.Jogador;
using dotNet_ApiRobusta461.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Aplicação...");

            ServiceJogador service = new ServiceJogador();

            AutenticarJogadorRequest requestAutenticar = new AutenticarJogadorRequest()
            {
                Email = "thwyster@hotmail.com",
                Senha = "12345"
            };
            AutenticarJogadorResponse responseAutenticar = service.AutenticarJogador(requestAutenticar);


            AdicionarJogadorRequest requestAdicionar = new AdicionarJogadorRequest()
            {
                Email = "joaosilva@hotmail.com",
                PrimeiroNome = "Joao",
                SegundoNome = "da Silva",
                Senha = "123456"
            };
            AdicionarJogadorResponse responseAdicionar = service.AdicionarJogador(requestAdicionar);

            Console.ReadKey();
        }
    }
}
