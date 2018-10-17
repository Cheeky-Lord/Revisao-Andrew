using Ninject.Modules;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDD.Infra.Context;
using DDD.Domain.Repositories;
using DDD.Infra.Repositories;
using DDD.Domain.Commands.Handlers;
using DDD.Shared.Commands;
using DDD.Domain.Commands.Inputs;

namespace DDD.WinApplication
{
    internal class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IDB>().To<MSSqlDB>();
            Bind<IUserRepository>().To<UserRepository>();
          
            //Bind<ICommandHandler<PublicCreateUser>>().To<UserHandler>();
            //Bind<UserHandler>();
            
        }
    }
}
