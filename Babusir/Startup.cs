using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Babusir.Startup))]
namespace Babusir
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
