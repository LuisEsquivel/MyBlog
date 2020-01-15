using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LDev.Startup))]
namespace LDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
