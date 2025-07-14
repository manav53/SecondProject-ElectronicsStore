using ElectronicsStore.Domain.Abstract;
using ElectronicsStore.Domain.Concrete;
using ElectronicsStore.WebUI.Infrastructure.Abstract;
using ElectronicsStore.WebUI.Infrastructure.Concrete;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Services.Description;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace ElectronicsStore.WebUI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            EmailSettings emailSettings = new EmailSettings
            {
                WriteAsFile = bool.Parse(ConfigurationManager
                 .AppSettings["Email.WriteAsFile"] ?? "false")
            };

            container.RegisterType<IProductRepository, EFProductRepository>();
            //container.RegisterType<IOrderProcessor, EmailOrderProcessor>(new InjectionConstructor("settings",emailSettings));
          
            container.RegisterType<IAuthProvider,FormsAuthProvider>();

            container.RegisterInstance<EmailSettings>(emailSettings);

            // Register the EmailOrderProcessor
            container.RegisterType<IOrderProcessor, EmailOrderProcessor>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            //kernel.Bind<IProductRepository>().To<EFProductRepository>();

         

            //kernel.Bind<IOrderProcessor>().To<EmailOrderProcessor>()
            //    .WithConstructorArgument("settings", emailSettings);

            //kernel.Bind<IAuthProvider>().To<FormsAuthProvider>();

    //        container.RegisterType<MyService>(
    //new InjectionConstructor(
    //    new ResolvedParameter<IRepository>(),  // Unity will resolve this dependency
    //    "your_connection_string_here"          // A literal string provided by you
    //));
        }
    }
}