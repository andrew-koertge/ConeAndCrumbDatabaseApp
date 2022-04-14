using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConeAndCrumbDatabaseApp.Startup))]
namespace ConeAndCrumbDatabaseApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
