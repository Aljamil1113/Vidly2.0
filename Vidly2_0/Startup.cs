using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly2_0.Startup))]
namespace Vidly2_0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
