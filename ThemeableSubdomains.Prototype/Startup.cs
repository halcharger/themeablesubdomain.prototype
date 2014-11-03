using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThemeableSubdomains.Prototype.Startup))]
namespace ThemeableSubdomains.Prototype
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
