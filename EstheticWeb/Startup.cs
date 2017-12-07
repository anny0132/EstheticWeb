using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EstheticWeb.Startup))]
namespace EstheticWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
