using Ioc_AngularSPA.Api.Infraestructure;
using Ioc_AngularSPA.Service;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using Unity.WebApi;
using Ioc_AngularSPA.Repo;
using Ioc_AngularSPA.Data;
using Ioc_AngularSPA.Core.Data;

namespace Ioc_AngularSPA.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            ////var container = new UnityContainer();
            ////container.RegisterType<IUserService, UserService>();
            //////container.RegisterType<IDbContext, IocDbContext>(new HierarchicalLifetimeManager());
            //////container.RegisterType<IRepository<User>, Repository<User>>(new HierarchicalLifetimeManager());
            ////config.DependencyResolver = new UnityResolver(container);

            ////// Web API configuration and services
            ////config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            ////// Web API routes
            ////config.MapHttpAttributeRoutes();

            ////config.Routes.MapHttpRoute(
            ////    name: "DefaultApi",
            ////    routeTemplate: "api/{controller}/{id}",
            ////    defaults: new { id = RouteParameter.Optional }
            ////);
            //// Configuración y servicios de API web

            //// Rutas de API web
            //config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
            //config.MapHttpAttributeRoutes();
            //var container = new UnityContainer();
            //container.RegisterType<IUserService, UserService>();
            //config.DependencyResolver = new UnityDependencyResolver(container);

            //var jsonFormatter = config.Formatters.OfType < JsonMediaTypeFormatter().First();
            //jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
        //private void ConfigureWebApi(HttpConfiguration config)
        //{
        //    config.MapHttpAttributeRoutes();
        //    var container = new UnityContainer();
        //    container.RegisterType<IValidator, Validator>();
        //    config.DependencyResolver = new UnityDependencyResolver(container);

        //    var jsonFormatter = config.Formatters.OfType < JsonMediaTypeFormatter().First();
        //    jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        //}
    }
}
