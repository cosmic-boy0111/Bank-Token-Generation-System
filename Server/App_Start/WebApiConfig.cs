using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Server
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Registre controller routes

            //config.Routes.MapHttpRoute(
            //    name: "message",
            //    routeTemplate: "api/register/Message",
            //    defaults: new { controller = "Register", action = "Message" }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "message2",
            //    routeTemplate: "api/register/Message2",
            //    defaults: new { controller = "Register", action = "Message2" }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "registration",
            //    routeTemplate: "api/register/Register",
            //    defaults: new { controller = "Register", action = "Register" }
            //);


            //// manager controller routes

            //config.Routes.MapHttpRoute(
            //    name: "allServices",
            //    routeTemplate: "api/manager/allServices",
            //    defaults: new { controller = "Manager", action = "AllServices" }
            //);
            
            //config.Routes.MapHttpRoute(
            //    name: "addService",
            //    routeTemplate: "api/manager/addService",
            //    defaults: new { controller = "Manager", action = "AddService" }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "deleteService",
            //    routeTemplate: "api/manager/deleteService",
            //    defaults: new { controller = "Manager", action = "DeleteService" }
            //);

            //config.Routes.MapHttpRoute(
            //    name: "updateService",
            //    routeTemplate: "api/manager/updateService",
            //    defaults: new { controller = "Manager", action = "UpdateService" }
            //);



        }
    }
}
