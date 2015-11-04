using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErDetOnsdag.Startup))]
namespace ErDetOnsdag
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
