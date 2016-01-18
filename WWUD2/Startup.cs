using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WUDIF.Startup))]
namespace WUDIF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
