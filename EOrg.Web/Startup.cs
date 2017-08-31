using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EOrg.Web.Startup))]
namespace EOrg.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
