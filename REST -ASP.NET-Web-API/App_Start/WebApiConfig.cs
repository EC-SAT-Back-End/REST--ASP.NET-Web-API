using System.Web.Http;

namespace REST__ASP.NET_Web_API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
           // config.Routes.MapHttpRoute(
           // name: "MyRoute",
           //routeTemplate: "api/{controller}/{year}/{month}/{day}",
           //defaults: new {
           //    year= RouteParameter.Optional,
           //    month = RouteParameter.Optional,
           //    day = RouteParameter.Optional

           //}
           //);
        }
    }
}