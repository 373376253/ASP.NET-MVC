using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Baiduyun.Web.Startup))]
namespace Baiduyun.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
