using dotNet_ApiRobusta461.Domain.Interfaces.Repositories;
using dotNet_ApiRobusta461.Domain.Interfaces.Repositories.Base;
using dotNet_ApiRobusta461.Domain.Interfaces.Services;
using dotNet_ApiRobusta461.Domain.Services;
using dotNet_ApiRobusta461.Infra.Persistence;
using dotNet_ApiRobusta461.Infra.Persistence.Repositories;
using dotNet_ApiRobusta461.Infra.Persistence.Repositories.Base;
using dotNet_ApiRobusta461.Infra.Transactions;
using Microsoft.Practices.Unity;
using prmToolkit.NotificationPattern;
using System.Data.Entity;

namespace dotNet_ApiRobusta461.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {

            container.RegisterType<DbContext, MeuContext>(new HierarchicalLifetimeManager());
            //UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            //container.RegisterType(typeof(IServiceBase<,>), typeof(ServiceBase<,>));

            container.RegisterType<IServiceJogador, ServiceJogador>(new HierarchicalLifetimeManager());
            container.RegisterType<IServiceJogo, ServiceJogo>(new HierarchicalLifetimeManager());

            //Repository
            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositoryJogador, RepositoryJogador>(new HierarchicalLifetimeManager());
            container.RegisterType<IRepositoryJogo, RepositoryJogo>(new HierarchicalLifetimeManager());
        }
    }
}
