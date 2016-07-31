using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KidsEntertainmentSite.Startup))]
namespace KidsEntertainmentSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
