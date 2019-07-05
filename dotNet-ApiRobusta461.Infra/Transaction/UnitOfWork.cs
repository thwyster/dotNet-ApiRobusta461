using dotNet_ApiRobusta461.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Infra.Transaction
{
    class UnitOfWork : IUnitOfWork
    {
        public readonly MeuContext _context;

        public UnitOfWork(MeuContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}
