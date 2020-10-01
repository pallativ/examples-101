using DependencyInjection.Services;
using Microsoft.AspNet.WebFormsDependencyInjection.Unity;
using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace ASP.NET_Examples_101
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            var container = this.AddUnity();
            container.RegisterType<IBusinessService, BusinessService>();
            container.RegisterType<IPersonService, PersonService>();

            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}