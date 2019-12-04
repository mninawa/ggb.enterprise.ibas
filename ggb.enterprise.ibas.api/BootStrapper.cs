using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;

using ggb.enterprise.ibas.applicationservice.Helpers;
using ggb.enterprise.ibas.common.data;
using ggb.enterprise.ibas.common.model;
using ggb.enterprise.ibas.common.model.Enum;
using ggb.enterprise.ibas.data.Repositories;
using ggb.enterprise.ibas.common.data.extensions;
using ggb.enterprise.ibas.common.model.Dto;
using ggb.enterprise.ibas.applicationservice.Contract;
using ggb.enterprise.ibas.applicationservice.Service;
using ggb.enterprise.ibas.model.Models;
using Autofac.Integration.WebApi;
using ggb.enterprise.ibas.data.Models;

namespace ggb.enterprise.ibas.api
{
    public static class Bootstrapper
    {
        public static void Run()
        {
            SetAutofacContainer();
        }

        public static void SetAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<GGBContext>().As(typeof(ApplicationContext)).WithParameter("nameOrConnectionString", "GGBContextEntities");
            builder.RegisterType<DatabaseFactory>().As<IDatabaseFactory<ApplicationContext>>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

     


            builder.RegisterType<UserRepository>().AsImplementedInterfaces()
              .WithParameters(new[] {
                new NamedParameter("connectionString", ConfigurationManager.ConnectionStrings["GGBContext"].ConnectionString),
                new NamedParameter("commandTimeout", Convert.ToInt32(60))
                });
       
            // Register the Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());


            // register repositories
            builder.RegisterAssemblyTypes(typeof(UserRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository") && !t.Name.Contains("User"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();


            //register services
            builder.RegisterAssemblyTypes(typeof(UserService).Assembly)
                .Where(t => t.Name.Contains("Service"))
                .AsImplementedInterfaces().InstancePerHttpRequest();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver =
                 new AutofacWebApiDependencyResolver(container);
            
        }
    }
}