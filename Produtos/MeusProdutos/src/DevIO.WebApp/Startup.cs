using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevIO.WebApp.Startup))]
namespace DevIO.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
