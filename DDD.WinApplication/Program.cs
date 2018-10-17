using Microsoft.Extensions.DependencyInjection;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD.WinApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Usando o Microsoft.Extensions.DependencyInjection
            //Configurando Serviços
            var Services = ConfigureServices.Configure(new ServiceCollection());
            //Acessando Provider
            var prov = Services.BuildServiceProvider();
            //Pegando o FORM1
            var form = prov.GetRequiredService<frmPublicCreateUser>();

            Application.Run(form);
        }
    }
}
