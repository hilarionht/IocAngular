using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using Ioc_AngularSPA.Service;
using System.Web.Http;
using Ioc_AngularSPA.Repo;
using Ioc_AngularSPA.Core.Data;

namespace Ioc_AngularSPA.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents(HttpConfiguration config)
        {
			var container = new UnityContainer();
            container.RegisterType<IRepository<User>, Repository<User>>();
            container.RegisterType<IUserService, UserService>();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            //container.RegisterInstance(typeof(HttpConfiguration), GlobalConfiguration.Configuration);
            //DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
            config.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);

        }
    }
}