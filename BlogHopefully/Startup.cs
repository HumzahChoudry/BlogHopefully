using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlogHopefully.Startup))]
namespace BlogHopefully
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
