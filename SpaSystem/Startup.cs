using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpaSystem.Startup))]
namespace SpaSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
