using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAngular4.Startup))]
namespace WebAppAngular4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
