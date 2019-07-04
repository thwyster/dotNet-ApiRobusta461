using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this)
                .IfNullOrInvalidLength(w => w.PrimeiroNome, 3, 50, "O primeiro nome deve ter pelo menos 3 a 50 caracteres")
                .IfNullOrInvalidLength(w => w.UltimoNome, 3, 50, "O ultimo nome deve ter pelo menos 3 a 50 caracteres");
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
    }
}
