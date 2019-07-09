using dotNet_ApiRobusta461.Infra.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet_ApiRobusta461.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MeuContext _context;

        public UnitOfWork(MeuContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
