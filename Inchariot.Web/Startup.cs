using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inchariot.Web.Startup))]
namespace Inchariot.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
