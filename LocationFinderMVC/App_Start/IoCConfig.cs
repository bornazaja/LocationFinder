using Autofac;
using Autofac.Integration.Mvc;
using LocationFinderLibrary.BLL.API.Places;
using LocationFinderLibrary.BLL.API.Places.Foursquare;
using System.Reflection;
using System.Web.Mvc;

namespace LocationFinderMVC.App_Start
{
    public static class IoCConfig
    {
        public static void Configure()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<FoursquarePlacesApi>().As<IPlacesApi>();
            containerBuilder.RegisterControllers(Assembly.GetExecutingAssembly());

            var container = containerBuilder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}