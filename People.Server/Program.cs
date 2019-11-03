using Autofac;
using Autofac.Integration.Wcf;
using People.DAL.Services;
using People.Server.ServiceContracts.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace People.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<FolksService>();
            builder.RegisterType<PeopleUnitOfWork>().As<IPeopleUnitOfWork>().SingleInstance();

            using (var container = builder.Build())
            {
                var host = new ServiceHost(typeof(FolksService));
                host.AddDependencyInjectionBehavior<FolksService>(container);
                host.Open();

                Console.WriteLine("Press <Any Key> for exit.");
                Console.ReadKey();

                host.Close();

                Environment.Exit(0);
            }
        }
    }
}
