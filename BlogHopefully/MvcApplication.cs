using Ninject;
using Ninject.Web.Common;
using System.Web.Routing;
using BlogHopefully.Core;
using BlogHopefully.Core.Mappings;

namespace BlogHopefully
{
    public class MvcApp : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Load(new RepositoryModule());
            kernel.Bind<IBlogRepository>().To<BlogRepository>();

            return kernel;
        }

        protected override void OnApplicationStarted()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            base.OnApplicationStarted();
        }
    }
}