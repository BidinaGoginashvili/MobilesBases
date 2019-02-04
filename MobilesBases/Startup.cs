using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobilesBases.Startup))]
namespace MobilesBases
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
