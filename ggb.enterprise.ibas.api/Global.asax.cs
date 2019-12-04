using AutoMapper;
using ggb.enterprise.ibas.api.Models;
using ggb.enterprise.ibas.model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ggb.enterprise.ibas.api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Bootstrapper.Run();
            ConfigureViewModelMappings();
        }

        private static void ConfigureViewModelMappings()
        {
            Mapper.CreateMap<Person, PersonViewModel>()
                .ForMember(vm => vm.Id, em => em.MapFrom(c => c.Identifier == null ? 0 : c.Identifier))
                .ForMember(vm => vm.FirstName, em => em.MapFrom(c => c.First_name))
                .ForMember(vm => vm.LastName, em => em.MapFrom(c => c.Surname))
                .ReverseMap();

        }
    }
}
