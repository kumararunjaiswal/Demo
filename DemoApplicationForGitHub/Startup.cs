using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoApplicationForGitHub.Startup))]
namespace DemoApplicationForGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
