using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HealthApp.Startup))]
namespace HealthApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
