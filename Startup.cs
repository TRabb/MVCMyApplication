using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMyApplication.Startup))]
namespace MVCMyApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
