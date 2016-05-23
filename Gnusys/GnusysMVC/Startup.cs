using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GnusysMVC.Startup))]
namespace GnusysMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
