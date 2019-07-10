using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        protected Email()
        {

        }

        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(w => w.Endereco);
        }

        public string Endereco { get; private set; }
    }
}
