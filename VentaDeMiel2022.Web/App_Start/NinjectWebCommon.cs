using System;
using System.Web;
using VentaDeMiel2022.Datos;
using Microsoft.Web.Infrastructure.DynamicModuleHelper;

using Ninject;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Servicio.Servicios.Facades;
using VentaDeMiel2022.Servicio.Servicios;
[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(VentaDeMiel2022.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(VentaDeMiel2022.Web.App_Start.NinjectWebCommon), "Stop")]

namespace VentaDeMiel2022.Web.App_Start
{
    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application.
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }

        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IRepositorioCliente>().To<RepositorioClientes>().InRequestScope();
            kernel.Bind<IServicioClientes>().To<ServicioCliente>().InRequestScope();

            kernel.Bind<IRepositorioLocalidad>().To<RepositorioLocalidades>().InRequestScope();
            kernel.Bind<IServicioLocalidad>().To<ServicioLocalidad>().InRequestScope();

            kernel.Bind<IRepositorioPais>().To<RepositorioPaises>().InRequestScope();
            kernel.Bind<IServicioPais>().To<ServicioPaises>().InRequestScope();

            kernel.Bind<IRepositorioProvincia>().To<RepositorioProvincia>().InRequestScope();
            kernel.Bind<IServicioProvincia>().To<ServicioProvincia>().InRequestScope();

            kernel.Bind<IRepositorioTipoDeDocumento>().To<RepositorioTipoDeDocumento>().InRequestScope();
            kernel.Bind<IServicioTipoDeDocumentos>().To<ServicioTipoDeDocumento>().InRequestScope();

            kernel.Bind<IRepositorioTipoEnvase>().To<RepositorioTipoEnvase>().InRequestScope();
            kernel.Bind<IServicioTipoEnvase>().To<ServicioTipoEnvase>().InRequestScope();

            kernel.Bind<IRepositorioVendedor>().To<RepositorioVendedores>().InRequestScope();
            kernel.Bind<IServicioVendedor>().To<ServicioVendedor>().InRequestScope();

           
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();

            kernel.Bind<VentaDeMiel2022DbContext>().ToSelf().InSingletonScope();

        }
    }
}