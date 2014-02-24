using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BloodAndSteel.Web.Startup))]
namespace BloodAndSteel.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
