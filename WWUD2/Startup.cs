using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WWUD2.Startup))]
namespace WWUD2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
