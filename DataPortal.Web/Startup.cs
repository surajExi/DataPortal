using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataPortal.Web.Startup))]
namespace DataPortal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
