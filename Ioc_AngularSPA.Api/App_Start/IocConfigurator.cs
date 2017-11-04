
using Ioc_AngularSPA.Service;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ioc_AngularSPA.Api.Infraestructure;

namespace Ioc_AngularSPA.Api.App_Start
{
    public static class IocConfigurator
    {
        public static void ConfigureIocUnityContainer()
        {
            IUnityContainer container = new UnityContainer();

            registerService(container);

            DependencyResolver.SetResolver(new DemoUnitDependencyResolver(container));
        }

        private static void registerService(IUnityContainer container)
        {
            container.RegisterType<IUserService, UserService>();


        }
    }
}