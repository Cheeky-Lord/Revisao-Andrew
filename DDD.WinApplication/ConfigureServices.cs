
using DDD.Domain.Commands.Handlers;
using DDD.Domain.Repositories;
using DDD.Infra.Context;
using DDD.Infra.Repositories;
using DDD.WinApplication.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DDD.WinApplication
{
    public static class ConfigureServices
    {

        public static ServiceCollection Configure(ServiceCollection services)
        {
            //Adicionando os Serviços
            services.AddTransient<IUserRepository,UserRepository>();
            services.AddTransient<UserHandler>();
            services.AddTransient<frmPublicCreateUser>();
            services.AddTransient<IDBConfiguration, MSSQLConfiguration>();
            services.AddSingleton<IDB,MSSqlDB>();
            

            return services;
        }
    }
}

