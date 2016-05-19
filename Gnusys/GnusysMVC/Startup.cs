using Microsoft.Owin;
using MySql.Data.Entity;
using Owin;
using System.Data.Entity;

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
