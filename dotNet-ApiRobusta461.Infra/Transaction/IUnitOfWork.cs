using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Infra.Transaction
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
