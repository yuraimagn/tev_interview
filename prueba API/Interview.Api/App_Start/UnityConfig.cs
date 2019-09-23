using Interview.Basic.DataAccess;
using Interview.Basic.DataAccess.Interfaces;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace Interview.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterSingleton<IUserData, UserData>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}