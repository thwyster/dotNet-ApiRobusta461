using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Domain.Arguments.Base
{
    public class ResponseBase
    {
        public string Message { get; set; }

        public ResponseBase()
        {
            Message = "Operacação realizada com Sucesso";
        }
    }
}
