using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotNet_ApiRobusta461.Domain.Entities;

namespace dotNet_ApiRobusta461.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public string Message { get; set; }

        public ResponseBase()
        {
            Message = "Operacação realizada com Sucesso";
        }

        public static explicit operator ResponseBase(Entities.Jogo jogo)
        {
            return new ResponseBase()
            {
                Message = "Operacao realizada com sucesso"
            };
        }
    }
}
