using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ahhh.Startup))]
namespace ahhh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
