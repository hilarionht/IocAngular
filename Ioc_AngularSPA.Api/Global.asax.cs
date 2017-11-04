using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using Ioc_AngularSPA.Service;
using Ioc_AngularSPA.Repo;
using Ioc_AngularSPA.Data;
using Ioc_AngularSPA.Core.Data;
using Ioc_AngularSPA.Api.App_Start;

namespace Ioc_AngularSPA.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
          
            AreaRegistration.RegisterAllAreas();
            //UnityConfig.RegisterComponents();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilter(GlobalFilters.Filters);
            DependencyConfig.Config();
            //FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            //RouteConfig.RegisterRoutes(RouteTable.Routes);
            //BundleConfig.RegisterBundles(BundleTable.Bundles);


            //var container = new Container();
            ////container.Register<IDbContext, IocDbContext>();
            //container.Register<IDbContext, IocDbContext>();
            ////container.Register<IUserService, UserService>();
            //container.Register<IRepository<User>, Repository<User>>();
            //container.Register<IRepository<UserProfile>, Repository<UserProfile>>();

            //container.Verify();

            //DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            //GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorDependencyResolver(container);

        }
    }
}
