using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tennisclub.Startup))]
namespace Tennisclub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
