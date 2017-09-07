using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAuthentication1.Startup))]
namespace OAuthentication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
