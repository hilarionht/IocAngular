using Ioc_AngularSPA.Core.Data;
using Ioc_AngularSPA.Repo;
using Ioc_AngularSPA.Service;
using LightInject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Ioc_AngularSPA.Api.App_Start
{
    public class DependencyConfig
    {
        public static void Config()
        {
            var container = new ServiceContainer();
            container.Register<IRepository<User>, Repository<User>>();
            container.Register<IUserService, UserService>();
            //container.Register<IService, Service1>("Service1");
            //container.Register<IService, Service2>("Service2");

            container.RegisterApiControllers();
            container.EnablePerWebRequestScope();
            container.EnableWebApi(GlobalConfiguration.Configuration);
        }
    }
}