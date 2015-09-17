using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPMvcFirstApplication.Startup))]
namespace ASPMvcFirstApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
